using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuangProject
{
    public partial class TC_ThuTien : Form
    {
        bool fl_new = true;
        DataTable dtBC;
        public TC_ThuTien()
        {
            InitializeComponent();
        }

        private void TC_ThuTien_Load(object sender, EventArgs e)
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_MaKH.aaDataSource = table1;
            cbo_MaKH.aaSelectIndex = 0;

            DataTable table2 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row2 = table2.NewRow();
            row2["Code"] = "";
            row2["Name"] = "";
            table2.Rows.InsertAt(row2, 0);
            cbo_MaKH_BC.aaDataSource = table2;
            cbo_MaKH_BC.aaSelectIndex = 0;

            Common.obj.Add_NewCommand("Select Code = MaTC, Name = TenTC from TC_MaTC where LoaiTC = 'Thu'", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table3 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row3 = table3.NewRow();
            row3["Code"] = "";
            row3["Name"] = "";
            table3.Rows.InsertAt(row3, 0);
            cbo_LoaiTC.aaDataSource = table3;
            cbo_LoaiTC.aaValueCode = "PT";

            DataTable table4 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row4 = table4.NewRow();
            row4["Code"] = "";
            row4["Name"] = "";
            table4.Rows.InsertAt(row4, 0);
            cbo_LoaiTC_BC.aaDataSource = table4;
            cbo_LoaiTC_BC.aaSelectIndex = 0;

            ShowCongTo();
            GetData_BC();
        }

        private void ShowCongTo()
        {
            Common.obj.Add_NewCommand("sys_ShowCongto", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiTC.aaValueCode.ToString());
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            txt_MaPhieu.Text = table.Rows[0][0].ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            cbo_LoaiTC.Enabled = cbo_MaKH.Enabled = txt_LyDo.Enabled = txt_TongTien.Enabled = true;
            ShowCongTo();
            fl_new = true;
            txt_TongTien.Text = "0";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            cbo_LoaiTC.Enabled = cbo_MaKH.Enabled = txt_LyDo.Enabled = txt_TongTien.Enabled = true;
            fl_new = false;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            cbo_LoaiTC.Enabled = cbo_MaKH.Enabled = txt_LyDo.Enabled = txt_TongTien.Enabled = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Phiếu thu này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (txt_MaPhieu.Text != "")
                {
                    try
                    {
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("Update TC_PhieuThuChi set Huy = 1 where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        MessageBox.Show("Xóa phiếu thành công !", "Thông báo");
                        Common.obj.CommitTransaction();
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        throw ex;
                    }
                    GetData_BC();
                    fl_new = true;
                }
            }
            GetData_BC();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cbo_LoaiTC.Enabled = cbo_MaKH.Enabled = txt_LyDo.Enabled = txt_TongTien.Enabled = false;
            if(cbo_MaKH.aaValueCode.ToString() != "" & txt_TongTien.Text != "0")
            {
                if (fl_new == true)
                {
                    Common.obj.BeginTransaction();
                    Common.obj.Add_NewCommand("sys_SetCongto", sys_ConData.sys_ConData.cmdType.Store);
                    Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiTC.aaValueCode.ToString());
                    Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                    Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                    Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiTC.aaValueCode.ToString());
                    DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                    Common.obj.Add_NewCommand("Insert into TC_PhieuThuChi (MaPhieu, MaTC, LoaiTC, MaKH, SoTien, NoiDung, NgayLap) values (@MaPhieu, @MaTC, @LoaiTC, @MaKH, @SoTien, @NoiDung, @NgayLap)", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                    Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                    Common.obj.Add_MyParametersCommand("@MaTC", SqlDbType.NVarChar, cbo_LoaiTC.aaValueCode.ToString());
                    Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
                    Common.obj.Add_MyParametersCommand("@NoiDung", SqlDbType.NVarChar, txt_LyDo.Text);
                    Common.obj.Add_MyParametersCommand("@SoTien", SqlDbType.Float, txt_TongTien.Text);
                    Common.obj.Add_MyParametersCommand("@LoaiTC", SqlDbType.NVarChar, "Thu");
                    Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                    MessageBox.Show("Lưu thành công", "Thông báo");

                    Common.obj.CommitTransaction();

                }
                else
                {
                    Common.obj.BeginTransaction();
                    Common.obj.Add_NewCommand("Update TC_PhieuThuChi  set  MaTC = @MaTC, LoaiTC = @LoaiTC, MaKH = @MaKH, SoTien = @SoTien, NoiDung = @NoiDung, NgayLap = @NgayLap where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                    Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                    Common.obj.Add_MyParametersCommand("@MaTC", SqlDbType.NVarChar, cbo_LoaiTC.aaValueCode.ToString());
                    Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
                    Common.obj.Add_MyParametersCommand("@NoiDung", SqlDbType.NVarChar, txt_LyDo.Text);
                    Common.obj.Add_MyParametersCommand("@SoTien", SqlDbType.Float, txt_TongTien.Text);
                    Common.obj.Add_MyParametersCommand("@LoaiTC", SqlDbType.NVarChar, "Thu");
                    Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                    MessageBox.Show("Lưu thành công", "Thông báo");

                    Common.obj.CommitTransaction();

                }
                fl_new = true;
            }
            GetData_BC();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_BK_PhieuThuChi", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtp_TuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtp_DenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@MaTC", SqlDbType.NVarChar, cbo_LoaiTC_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "Thu");
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã phiếu";
                g_BC.Cols[1].Width = 210;
                g_BC.Cols[1].AllowEditing = false;
                g_BC.Cols[2].Caption = "Ngày ";
                g_BC.Cols[2].Width = 100;
                g_BC.Cols[2].Format = "dd/MM/yyyy";
                g_BC.Cols[2].AllowEditing = false;
                g_BC.Cols[2].Visible = true;
                g_BC.Cols[3].Caption = "Loại TC";
                g_BC.Cols[3].Width = 80;
                g_BC.Cols[3].AllowEditing = true;
                g_BC.Cols[4].Caption = "Mã KH";
                g_BC.Cols[4].Format = "##,##0";
                g_BC.Cols[4].Width = 70;
                g_BC.Cols[5].Caption = "Tên KH";
                g_BC.Cols[5].Width = 170;
                g_BC.Cols[6].Caption = "Số tiền";
                g_BC.Cols[6].Format = "##,##0";
                g_BC.Cols[6].Width = 120;
                g_BC.Cols[7].Caption = "Nội dung";
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    g_BC.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }

        private void cbo_LoaiTC_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_MaKH_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtp_DenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtp_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void g_BC_MouseClick(object sender, MouseEventArgs e)
        {
            if(g_BC.Rows.Count > 1)
            {
                if(g_BC[g_BC.Row, "MaPhieu"].ToString() != "")
                {
                    cbo_LoaiTC.Enabled = cbo_MaKH.Enabled = txt_LyDo.Enabled = txt_TongTien.Enabled = false;
                    txt_MaPhieu.Text = g_BC[g_BC.Row, "MaPhieu"].ToString();
                    Common.obj.Add_NewCommand("Select * from TC_PhieuThuChi where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                    DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    cbo_LoaiTC.aaValueCode = table.Rows[0]["MaTC"].ToString();
                    cbo_MaKH.aaValueCode = table.Rows[0]["MaKH"].ToString();
                    dtp_NgayLap.Text = table.Rows[0]["NgayLap"].ToString();
                    txt_LyDo.Text = table.Rows[0]["NoiDung"].ToString();
                    txt_TongTien.Text = table.Rows[0]["SoTien"].ToString();
                    fl_new = false;
                }
            }
            

        }

        private void cbo_LoaiTC_aaItemSelected(object sender, EventArgs e)
        {
            ShowCongTo();
        }

        private void g_BC_Click(object sender, EventArgs e)
        {

        }
    }
}
