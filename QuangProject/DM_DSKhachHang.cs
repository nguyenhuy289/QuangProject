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
    public partial class DM_DSKhachHang : Form
    {
        private bool addnewKH = true;
        private DataTable dtDSKH;
        private DataTable dtDSKH1;
        public DM_DSKhachHang()
        {
            InitializeComponent();
            Common.obj = new sys_ConData.sys_ConData();
        }

        private void btn_New_KH_Click(object sender, EventArgs e)
        {
            txt_MaKH.Enabled = txt_TenKH.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = txt_Zalo.Enabled = chk_SuDung_KH.Enabled =  true;
            txt_MaKH.Text = txt_TenKH.Text = "";
            chk_SuDung_KH.Checked = chk_KH.Checked = true;
            chk_NCC.Checked = chk_NV.Checked = false;
            addnewKH = true;

        }

        private void btn_Edit_KH_Click(object sender, EventArgs e)
        {
            if(txt_MaKH.Text == "")
            {
                return;
            }    
            txt_TenKH.Enabled = chk_SuDung_KH.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = txt_Zalo.Enabled = true;
            addnewKH = false;
        }

        private void btn_Del_KH_Click(object sender, EventArgs e)
        {
            if (addnewKH == true)
            {

            }
            else
            {
                if (txt_MaKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Mã Khách hàng", "Thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Khách hàng này ???", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Common.obj.Add_NewCommand("Delete DM_KhachHang where MaKH = @MaKH", sys_ConData.sys_ConData.cmdType.Query);
                            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, txt_MaKH.Text);
                            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                            txt_MaKH.Text = txt_TenKH.Text = "";
                            MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                        }
                        catch (Exception ex1)
                        {
                            Exception ex = ex1;
                            ProjectData.SetProjectError(ex);
                            throw ex;
                        }
                    }
                }
            }
        }

        private void DM_DSKhachHang_Load(object sender, EventArgs e)
        {
            GetData_DSKH();
            g_KH.DataSource = dtDSKH;
            FillColorGrid_g_KH();
            g_KH.Show();
        }
        private void GetData_DSKH()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaKH, TenKH, KH, NCC, NV from DM_KhachHang where SuDung = @SuDung and (KH = @KH and NCC = @NCC and NV = @NV) order by KH, NCC, NV, MaKH ASC", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 1);
                Common.obj.Add_MyParametersCommand("@KH", SqlDbType.NVarChar, chk_KH_BC.Checked);
                Common.obj.Add_MyParametersCommand("@NCC", SqlDbType.NVarChar, chk_NCC_BC.Checked);
                Common.obj.Add_MyParametersCommand("@NV", SqlDbType.NVarChar, chk_NV_BC.Checked);
                dtDSKH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            
        }
        private void GetData_DSKH1()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaKH, TenKH, KH, NCC, NV from DM_KhachHang where SuDung = @SuDung and (KH = @KH and NCC = @NCC and NV = @NV) order by KH, NCC, NV, MaKH ASC", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 0);
                Common.obj.Add_MyParametersCommand("@KH", SqlDbType.NVarChar, chk_KH_BC.Checked);
                Common.obj.Add_MyParametersCommand("@NCC", SqlDbType.NVarChar, chk_NCC_BC.Checked);
                Common.obj.Add_MyParametersCommand("@NV", SqlDbType.NVarChar, chk_NV_BC.Checked);
                dtDSKH1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private void FillColorGrid_g_KH()
        {
            try
            {
                g_KH.Cols[1].Caption = "Mã Khách";
                g_KH.Cols[1].Width = 100;
                g_KH.Cols[2].Caption = "Tên Khách hàng";
                g_KH.Cols[2].Width = 350;
                g_KH.Cols[3].Caption = "Khách hàng";
                g_KH.Cols[3].Width = 100;
                g_KH.Cols[4].Caption = "Nhà CC";
                g_KH.Cols[4].Width = 100;
                g_KH.Cols[5].Caption = "Nhân viên";
                g_KH.Cols[5].Width = 100;
                g_KH.Rows[0].Height = 30;
                g_KH.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_KH.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_KH.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_KH.Rows[i].Height = 30;
                }
                

            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }

        private void btn_Save_KH_Click(object sender, EventArgs e)
        {
            if (chk_KH.Checked == false & chk_NCC.Checked == false & chk_NV.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn loại Khách hàng", "Thông báo");
            }
            else
            {
                if (addnewKH == true)
                {
                    try
                    {
                        Common.obj.Add_NewCommand("Insert into DM_KhachHang (MaKH, TenKH, GiaBan, SuDung, NCC, NV, KH, SDT, DiaChi, Zalo) values (@MaKH, @TenKH, @GiaBan, @SuDung, @NCC, @NV, @KH, @SDT, @DiaChi, @Zalo)", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, txt_MaKH.Text);
                        Common.obj.Add_MyParametersCommand("@TenKH", SqlDbType.NVarChar, txt_TenKH.Text);
                        Common.obj.Add_MyParametersCommand("@GiaBan", SqlDbType.NVarChar, cbo_DonGia.Text);
                        Common.obj.Add_MyParametersCommand("@SDT", SqlDbType.NVarChar, txt_SDT.Text);
                        Common.obj.Add_MyParametersCommand("@DiaChi", SqlDbType.NVarChar, txt_DiaChi.Text);
                        Common.obj.Add_MyParametersCommand("@Zalo", SqlDbType.NVarChar, txt_Zalo.Text);
                        Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_SuDung_KH.Checked));
                        Common.obj.Add_MyParametersCommand("@KH", SqlDbType.Bit, Conversions.ToInteger(chk_KH.Checked));
                        Common.obj.Add_MyParametersCommand("@NCC", SqlDbType.Bit, Conversions.ToInteger(chk_NCC.Checked));
                        Common.obj.Add_MyParametersCommand("@NV", SqlDbType.Bit, Conversions.ToInteger(chk_NV.Checked));
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                    }
                    catch (Exception ex1)
                    {
                        Exception ex = ex1;
                        ProjectData.SetProjectError(ex);
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        Common.obj.Add_NewCommand("Update DM_KhachHang set TenKH = @TenKH, GiaBan = @GiaBan, SuDung = @SuDung, KH = @KH, NCC = @NCC, NV = @NV, SDT = @SDT, DiaChi = @DiaChi, Zalo = @Zalo where MaKH = @MaKH", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, txt_MaKH.Text);
                        Common.obj.Add_MyParametersCommand("@TenKH", SqlDbType.NVarChar, txt_TenKH.Text);
                        Common.obj.Add_MyParametersCommand("@GiaBan", SqlDbType.NVarChar, cbo_DonGia.Text);
                        Common.obj.Add_MyParametersCommand("@SDT", SqlDbType.NVarChar, txt_SDT.Text);
                        Common.obj.Add_MyParametersCommand("@DiaChi", SqlDbType.NVarChar, txt_DiaChi.Text);
                        Common.obj.Add_MyParametersCommand("@Zalo", SqlDbType.NVarChar, txt_Zalo.Text);
                        Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_SuDung_KH.Checked));
                        Common.obj.Add_MyParametersCommand("@KH", SqlDbType.Bit, Conversions.ToInteger(chk_KH.Checked));
                        Common.obj.Add_MyParametersCommand("@NCC", SqlDbType.Bit, Conversions.ToInteger(chk_NCC.Checked));
                        Common.obj.Add_MyParametersCommand("@NV", SqlDbType.Bit, Conversions.ToInteger(chk_NV.Checked));
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                    }
                    catch (Exception ex1)
                    {
                        Exception ex = ex1;
                        ProjectData.SetProjectError(ex);
                        throw ex;
                    }
                }
            }
            GetData_DSKH();
            g_KH.DataSource = dtDSKH;
            FillColorGrid_g_KH();
            g_KH.Show();
            txt_MaKH.Enabled = txt_TenKH.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = txt_Zalo.Enabled = false;
        }

        private void chk_SuDungKH_BC_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_SuDungKH_BC.Checked == true)
            {
                GetData_DSKH();
                g_KH.DataSource = dtDSKH;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
            else
            {
                GetData_DSKH1();
                g_KH.DataSource = dtDSKH1;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
        }

        private void g_KH_MouseDown(object sender, MouseEventArgs e)
        {
            if (g_KH.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để chọn !", "Thông báo");
                return;
            }
            else
            {       
                addnewKH = false;
                Common.obj.Add_NewCommand("Select * from DM_KhachHang where MaKH = @MaKH", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, g_KH[g_KH.Row, "MaKH"].ToString());
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                txt_TenKH.Text = table.Rows[0]["TenKH"].ToString();
                txt_MaKH.Text = table.Rows[0]["MaKH"].ToString();
                txt_SDT.Text = table.Rows[0]["SDT"].ToString();
                txt_DiaChi.Text = table.Rows[0]["DiaChi"].ToString();
                txt_Zalo.Text = table.Rows[0]["Zalo"].ToString();
                cbo_DonGia.Text = table.Rows[0]["GiaBan"].ToString();
                chk_SuDung_KH.Checked = Conversions.ToBoolean(table.Rows[0]["SuDung"]);
                chk_KH.Checked = Conversions.ToBoolean(table.Rows[0]["KH"]);
                chk_NCC.Checked = Conversions.ToBoolean(table.Rows[0]["NCC"]);
                chk_NV.Checked = Conversions.ToBoolean(table.Rows[0]["NV"]);
                txt_MaKH.Enabled = txt_TenKH.Enabled = chk_SuDung_KH.Enabled = false;
                    
            }
        }

        private void chk_KH_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_KH.Checked == true)
            {
                chk_NCC.Checked = chk_NV.Checked = false;
            } 
        }

        private void chk_NCC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NCC.Checked == true)
            {
                chk_KH.Checked = chk_NV.Checked = false;
            }
        }

        private void chk_NV_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NV.Checked == true)
            {
                chk_KH.Checked = chk_NCC.Checked = false;
            }
        }

        private void chk_NV_BC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NV_BC.Checked == true)
            {
                chk_KH_BC.Checked = chk_NCC_BC.Checked = false;
            }
            if (chk_SuDungKH_BC.Checked == true)
            {
                GetData_DSKH();
                g_KH.DataSource = dtDSKH;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
            else
            {
                GetData_DSKH1();
                g_KH.DataSource = dtDSKH1;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
        }

        private void chk_NCC_BC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NCC_BC.Checked == true)
            {
                chk_KH_BC.Checked = chk_NV_BC.Checked = false;
            }
            if (chk_SuDungKH_BC.Checked == true)
            {
                GetData_DSKH();
                g_KH.DataSource = dtDSKH;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
            else
            {
                GetData_DSKH1();
                g_KH.DataSource = dtDSKH1;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
        }

        private void chk_KH_BC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_KH_BC.Checked == true)
            {
                chk_NCC_BC.Checked = chk_NV_BC.Checked = false;
            }
            if (chk_SuDungKH_BC.Checked == true)
            {
                GetData_DSKH();
                g_KH.DataSource = dtDSKH;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
            else
            {
                GetData_DSKH1();
                g_KH.DataSource = dtDSKH1;
                FillColorGrid_g_KH();
                g_KH.Redraw = true;
                g_KH.Show();
            }
        }
    }
}
