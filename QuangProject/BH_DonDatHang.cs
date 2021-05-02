using Microsoft.VisualBasic;
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
    public partial class BH_DonDatHang : Form
    {
        DataTable dt_Cbo_KH;
        DataTable dt_Cbo_KH_BC;
        DataTable dt_Cbo_HH;
        DataTable dt_Cbo_HH_BC;
        DataTable dt_Cbo_NH_BC;
        DataTable dtInfo;
        DataTable dtItem;
        DataTable dtBC;
        bool fl_new = true;

        public BH_DonDatHang()
        {
            Common.obj = new sys_ConData.sys_ConData();
            InitializeComponent();
        }

        private void BH_DonDatHang_Load(object sender, EventArgs e)
        {
            GetData_CboKH();
            GetData_CboHH();
            Common.obj.Add_NewCommand("Select Code = MaNhom, Name = TenNhom from DM_NhomHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_NH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_NH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_NH_BC.Rows.InsertAt(row, 0);
            cbo_NH_BC.aaDataSource = dt_Cbo_NH_BC;
            GetData("");
            GetData_BC();
            FillColorGrid_gItem();
        }
        private void ShowCongTo()
        {
            Common.obj.Add_NewCommand("sys_ShowCongTo", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "DH");
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            txt_MaPhieu.Text = table.Rows[0][0].ToString();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_BK_DonHangCho", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dptTuNgay.Value.ToString("yyyy-MM-dd"));
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dptDenNgay.Value.ToString("yyyy-MM-dd"));
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_NH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa_BC.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã phiếu";
                g_BC.Cols[1].Width = 250;
                g_BC.Cols[1].AllowEditing = false;
                g_BC.Cols[2].Caption = "Ngày ";
                g_BC.Cols[2].Width = 150;
                g_BC.Cols[2].Format = "dd/MM/yyyy";
                g_BC.Cols[2].AllowEditing = false;
                g_BC.Cols[2].Visible = true;
                g_BC.Cols[3].Caption = "Mã KH";
                g_BC.Cols[3].Width = 80;
                g_BC.Cols[3].AllowEditing = true;
                g_BC.Cols[4].Caption = "Tên KH";
                g_BC.Cols[4].Visible = true;
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_BC.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }
        private void GetData_CboKH()
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_KH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            cbo_MaKH.aaDataSource = dt_Cbo_KH;

            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_KH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_KH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_KH_BC.Rows.InsertAt(row, 0);
            cbo_KH_BC.aaDataSource = dt_Cbo_KH_BC;

        }
        private void GetData_CboHH()
        {
            Common.obj.Add_NewCommand("Select Code = MaHang, Name = TenHang from DM_HangHoa where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_HH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            cbo_HangHoa.aaDataSource = dt_Cbo_HH;

            Common.obj.Add_NewCommand("Select Code = MaHang, Name = TenHang from DM_HangHoa where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_HH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_HH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_HH_BC.Rows.InsertAt(row, 0);
            cbo_HangHoa_BC.aaDataSource = dt_Cbo_HH_BC;
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            fl_new = true;
            ShowCongTo();
            GetData(txt_MaPhieu.Text);
            FillColorGrid_gItem();
        }
        private void GetData(string MaPhieu)
        {
            Common.obj.Add_NewCommand("Select * from BH_DonHangCho where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, MaPhieu);
            dtInfo = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            Common.obj.Add_NewCommand(@"Select a.MaHang, b.TenHang, SL, MaPhieu, ID from BH_DonHangCho_Item a 
                                                    left outer join DM_HangHoa b on a.MaHang = b.MaHang where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, MaPhieu);
            dtItem = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
        }
        private void FillColorGrid_gItem()
        {
            try
            {
                g_Item.DataSource = dtItem;
                g_Item.Cols[1].Caption = "Mã hàng";
                g_Item.Cols[1].Width = 80;
                g_Item.Cols[1].AllowEditing = false;
                g_Item.Cols[2].Caption = "Tên hàng";
                g_Item.Cols[2].Width = 350;
                g_Item.Cols[2].AllowEditing = false;
                g_Item.Cols[2].Visible = true;
                g_Item.Cols[3].Caption = "SL";
                g_Item.Cols[3].Width = 70;
                g_Item.Cols[3].AllowEditing = true;
                g_Item.Cols[4].Caption = "Mã phiếu";
                g_Item.Cols[4].Width = 80;
                g_Item.Cols[4].Visible = false;
                g_Item.Cols[5].Caption = "ID";
                g_Item.Cols[5].Width = 80;
                g_Item.Cols[5].Visible = false;
                g_Item.Rows[0].Height = 25;
                g_Item.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_Item.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_Item.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_Item.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbo_HangHoa.aaValueCode.ToString() != "")
            {
                    Common.obj.Add_NewCommand("Select * from DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa.aaValueCode.ToString());
                    DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    if (table.Rows.Count == 0)
                    {
                        cbo_HangHoa.aaValueName = "";
                        cbo_HangHoa.aaValueCode = "";
                    }
                    else
                    {

                        DataRow row = this.dtItem.NewRow();
                        row["MaPhieu"] = this.txt_MaPhieu.Text;
                        row["MaHang"] = table.Rows[0]["MaHang"];
                        row["TenHang"] = table.Rows[0]["TenHang"];
                        row["SL"] = 10;
                        dtItem.Rows.Add(row);
                        g_Item.DataSource = dtItem;
                        FillColorGrid_gItem();
                        cbo_HangHoa.aaValueName = "";
                        cbo_HangHoa.aaValueCode = "";
                        cbo_HangHoa.Focus();
                    }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (fl_new == true)
            {
                if (cbo_MaKH.aaValueCode.ToString() == "")
                {
                    MessageBox.Show("Hãy chọn khách hàng", "Thông báo");
                    cbo_MaKH.Focus();
                    return;
                }
                Common.obj.BeginTransaction();
                Common.obj.Add_NewCommand("sys_SetCongto", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "DH");
                Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "DH");
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                Common.obj.Add_NewCommand("Insert into BH_DonHangCho (MaPhieu, NgayLap, MaKH) values (@MaPhieu, @NgayLap, @MaKH)", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
                Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString("yyyy-MM-dd"));
                Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                Common.obj.Add_NewCommand("select MaPhieu, MaHang, SL, ID  from BH_DonHangCho_Item", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.UpdateTable(Common.obj.Get_NewCommand(), dtItem);

                MessageBox.Show("Lưu thành công", "Thông báo");
                Common.obj.CommitTransaction();
                GetData_BC();
            }
            else
            {
                Common.obj.BeginTransaction();
                Common.obj.Add_NewCommand("Update BH_DonHangCho set NgayLap = @NgayLap, MaKH = @MaKH where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
                Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString("yyyy-MM-dd"));
                Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                Common.obj.Add_NewCommand("select MaPhieu, MaHang, SL, ID from BH_DonHangCho_Item", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.UpdateTable(Common.obj.Get_NewCommand(), dtItem);

                MessageBox.Show("Lưu thành công", "Thông báo");
                Common.obj.CommitTransaction();
                GetData_BC();
            }
        }

        private void g_Item_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if(g_Item[g_Item.Row, "MaPhieu"].ToString() == "")
            {
                g_Item[g_Item.Row, "MaPhieu"] = txt_MaPhieu.Text;
            }
        }

        private void cbo_KH_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dptDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dptTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void g_BC_Click(object sender, EventArgs e)
        {
            if (g_BC.Rows.Count > 1)
            {
                txt_MaPhieu.Text = g_BC[g_BC.Row, "MaPhieu"].ToString();
                Common.obj.Add_NewCommand("Select * from BH_DonHangCho where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                dtp_NgayLap.Text = table.Rows[0]["NgayLap"].ToString();
                cbo_MaKH.aaValueCode = table.Rows[0]["MaKH"].ToString();
                GetData(txt_MaPhieu.Text);
                FillColorGrid_gItem();
                fl_new = false;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Đơn hàng chờ này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Common.obj.BeginTransaction();
                Common.obj.Add_NewCommand("Update BH_DonHangCho set Huy = 1 where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                MessageBox.Show("Xóa thành công", "Thông báo");
                Common.obj.CommitTransaction();
                GetData_BC();
            }
            fl_new = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            fl_new = false;
        }
    }
}
