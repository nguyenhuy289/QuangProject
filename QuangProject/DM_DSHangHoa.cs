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
    public partial class DM_DSHangHoa : Form
    {
        private bool addnewNH = true;
        private bool addnewHH = true;
        private DataTable dtDSNH;
        private DataTable dtDSNH1;
        private DataTable dtDSHH;
        private DataTable dtDSHH1;
        private DataTable dt_cboNH;
        private DataTable dt_cboNH_BC;
        public DM_DSHangHoa()
        {
            InitializeComponent();
            Common.obj = new sys_ConData.sys_ConData();
        }

        private void DM_DSHangHoa_Load(object sender, EventArgs e)
        {
            cbo_CTrinh.SelectedIndex = 0;
            GetData_DSNH();
            g_NH.DataSource = dtDSNH;
            FillColorGrid_g_NH();
            g_NH.Show();

            GetData_DSHH();
            g_HH.DataSource = dtDSHH;
            FillColorGrid_g_HH();
            g_HH.Show();

            txt_DonGia2.Text = "0";

            GetData_CboNH();
        }
        private void GetData_CboNH()
        {
            Common.obj.Add_NewCommand("Select MaNhom, TenNhom from DM_NhomHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_cboNH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            cbo_Nhom.DataSource = dt_cboNH;

            Common.obj.Add_NewCommand("Select MaNhom, TenNhom from DM_NhomHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_cboNH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_cboNH_BC.NewRow();
            row["MaNhom"] = "";
            row["TenNhom"] = "";
            dt_cboNH_BC.Rows.InsertAt(row, 0);
            cbo_Nhom_BC.DataSource = dt_cboNH_BC;

        }
        private void btn_New_NhomHang_Click(object sender, EventArgs e)
        {
            txt_MaNhom.Focus();
            txt_MaNhom.Enabled = txt_TenNhom.Enabled = chk_Nhom.Enabled = true;
            txt_MaNhom.Text = txt_TenNhom.Text = "";
            chk_Nhom.Checked = true;
            addnewNH = true;
        }

        private void btn_New_HangHoa_Click(object sender, EventArgs e)
        {
            txt_MaHang.Enabled = txt_TenHang.Enabled = txt_DonGia1.Enabled = txt_DonGia2.Enabled = txt_DonGia3.Enabled = txt_DonGia4.Enabled = txt_SLToiThieu.Enabled = txt_GiaVon.Enabled = chk_Hang.Enabled = true;
            txt_MaHang.Text = txt_TenHang.Text = "";
            txt_DonGia1.Text = txt_DonGia2.Text = txt_DonGia3.Text = txt_DonGia4.Text = txt_SLToiThieu.Text = txt_GiaVon.Text = "0";
            chk_Hang.Checked = true;
            cbo_CTrinh.SelectedIndex = 0;
            addnewHH = true;
        }

        private void btn_Edit_NhomHang_Click(object sender, EventArgs e)
        {
            if (txt_MaNhom.Text == "")
            {
                return;
            }
            txt_TenNhom.Enabled = chk_Nhom.Enabled = true;
            addnewNH = false;
        }

        private void btn_Edit_HangHoa_Click(object sender, EventArgs e)
        {
            if (txt_MaHang.Text == "")
            {
                return;
            }
            txt_TenHang.Enabled = txt_DonGia1.Enabled = txt_DonGia2.Enabled = txt_DonGia3.Enabled = txt_DonGia4.Enabled = txt_SLToiThieu.Enabled = txt_GiaVon.Enabled = chk_Hang.Enabled = true;
            addnewHH = false;
        }

        private void btn_Del_NhomHang_Click(object sender, EventArgs e)
        {
            if (addnewNH == true)
            {

            }
            else
            {
                if (txt_MaNhom.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Mã Nhóm", "Thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhóm hàng này ???", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Common.obj.Add_NewCommand("Delete DM_NhomHang where MaNhom = @MaNhom", sys_ConData.sys_ConData.cmdType.Query);
                            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, txt_MaNhom.Text);
                            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                            txt_MaNhom.Text = txt_TenNhom.Text = "";
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
            GetData_CboNH();
            GetData_DSNH();
            g_NH.DataSource = dtDSNH;
            FillColorGrid_g_NH();
            g_NH.Show();
        }

        private void btn_Del_HangHoa_Click(object sender, EventArgs e)
        {
            if (addnewHH == true)
            {

            }
            else
            {
                if (txt_MaHang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Mã Hàng", "Thông báo");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Hàng hóa này ???", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Common.obj.Add_NewCommand("Delete DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, txt_MaHang.Text);
                            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                            txt_MaHang.Text = txt_TenHang.Text = "";
                            txt_DonGia1.Text = "0";
                            txt_DonGia2.Text = "0";
                            txt_DonGia3.Text = "0";
                            txt_DonGia4.Text = "0";
                            chk_Hang.Checked = true;
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

        private void btn_Save_NhomHang_Click(object sender, EventArgs e)
        {
            if (addnewNH == true)
            {
                try
                {
                    Common.obj.Add_NewCommand("Insert into DM_NhomHang (MaNhom, TenNhom, SuDung) values (@MaNhom, @TenNhom, @SuDung)", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, txt_MaNhom.Text);
                    Common.obj.Add_MyParametersCommand("@TenNhom", SqlDbType.NVarChar, txt_TenNhom.Text);
                    Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_Nhom.Checked));
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
                    Common.obj.Add_NewCommand("Update  DM_NhomHang set TenNhom = @TenNhom, SuDung = @SuDung where MaNhom = @MaNhom", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, txt_MaNhom.Text);
                    Common.obj.Add_MyParametersCommand("@TenNhom", SqlDbType.NVarChar, txt_TenNhom.Text);
                    Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_Nhom.Checked));
                    Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                }
                catch (Exception ex1)
                {
                    Exception ex = ex1;
                    ProjectData.SetProjectError(ex);
                    throw ex;
                }
            }
            GetData_CboNH();
            GetData_DSNH();
            g_NH.DataSource = dtDSNH;
            FillColorGrid_g_NH();
            g_NH.Show();
            chk_Nhom_BC.Checked = true;
            txt_MaNhom.Enabled = txt_TenNhom.Enabled = false;
        }

        private void btn_Save_HangHoa_Click(object sender, EventArgs e)
        {
            if (addnewHH == true)
            {
                try
                {
                    Common.obj.Add_NewCommand("Insert into DM_HangHoa (MaHang, TenHang, MaNhom, SLToiThieu, LoaiHang, GiaVon, DonGia1, DonGia2, DonGia3, DonGia4, SuDung) values (@MaHang, @TenHang, @MaNhom, @SLToiThieu, @LoaiHang, @GiaVon, @DonGia1, @DonGia2, @DonGia3, @DonGia4, @SuDung)", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, txt_MaHang.Text);
                    Common.obj.Add_MyParametersCommand("@TenHang", SqlDbType.NVarChar, txt_TenHang.Text);
                    Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_Nhom.SelectedValue.ToString());
                    Common.obj.Add_MyParametersCommand("@SLToiThieu", SqlDbType.Float, txt_SLToiThieu.Text);
                    Common.obj.Add_MyParametersCommand("@LoaiHang", SqlDbType.NVarChar, cbo_CTrinh.Text);
                    Common.obj.Add_MyParametersCommand("@GiaVon", SqlDbType.Float, txt_GiaVon.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia1", SqlDbType.Float, txt_DonGia1.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia2", SqlDbType.Float, txt_DonGia2.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia3", SqlDbType.Float, txt_DonGia3.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia4", SqlDbType.Float, txt_DonGia4.Text);
                    Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_Hang.Checked));
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
                    Common.obj.Add_NewCommand("Update DM_HangHoa set TenHang = @TenHang, MaNhom = @MaNhom, SLToiThieu = @SLToiThieu, LoaiHang = @LoaiHang, GiaVon = @GiaVon, DonGia1 = @DonGia1, DonGia2 = @DonGia2, DonGia3 = @DonGia3, DonGia4 = @DonGia4, SuDung = @SuDung  where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, txt_MaHang.Text);
                    Common.obj.Add_MyParametersCommand("@TenHang", SqlDbType.NVarChar, txt_TenHang.Text);
                    Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_Nhom.SelectedValue.ToString());
                    Common.obj.Add_MyParametersCommand("@SLToiThieu", SqlDbType.Float, txt_SLToiThieu.Text);
                    Common.obj.Add_MyParametersCommand("@LoaiHang", SqlDbType.NVarChar, cbo_CTrinh.Text);
                    Common.obj.Add_MyParametersCommand("@GiaVon", SqlDbType.Float, txt_GiaVon.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia1", SqlDbType.Float, txt_DonGia1.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia2", SqlDbType.Float, txt_DonGia2.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia3", SqlDbType.Float, txt_DonGia3.Text);
                    Common.obj.Add_MyParametersCommand("@DonGia4", SqlDbType.Float, txt_DonGia4.Text);
                    Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_Hang.Checked));
                    Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                }
                catch (Exception ex1)
                {
                    Exception ex = ex1;
                    ProjectData.SetProjectError(ex);
                    throw ex;
                }
            }
            GetData_DSHH();
            g_HH.DataSource = dtDSHH;
            FillColorGrid_g_HH();
            g_HH.Show();
            chk_Hang_BC.Checked = true;
            txt_MaHang.Enabled = txt_TenHang.Enabled = txt_DonGia1.Enabled = txt_DonGia2.Enabled = txt_DonGia3.Enabled = txt_DonGia4.Enabled = txt_SLToiThieu.Enabled = txt_GiaVon.Enabled = chk_Hang.Enabled = false;
        }

        private void chk_Nhom_BC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Nhom_BC.Checked == true)
            {
                GetData_DSNH();
                g_NH.DataSource = dtDSNH;
                FillColorGrid_g_NH();
                g_NH.Redraw = true;
                g_NH.Show();
            }
            else
            {
                GetData_DSNH1();
                g_NH.DataSource = dtDSNH1;
                FillColorGrid_g_NH();
                g_NH.Redraw = true;
                g_NH.Show();
            }
        }

        private void chk_Hang_BC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Hang_BC.Checked == true)
            {
                GetData_DSHH();
                g_HH.DataSource = dtDSHH;
                FillColorGrid_g_HH();
                g_HH.Redraw = true;
                g_HH.Show();
            }
            else
            {
                GetData_DSHH1();
                g_HH.DataSource = dtDSHH1;
                FillColorGrid_g_HH();
                g_HH.Redraw = true;
                g_HH.Show();
            }
        }

        private void g_NH_MouseDown(object sender, MouseEventArgs e)
        {
            if (g_NH.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để chọn !", "Thông báo");
                return;
            }
            else
            {
                addnewNH = false;
                Common.obj.Add_NewCommand("Select MaNhom, TenNhom, SuDung from DM_NhomHang where MaNhom = @MaNhom", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, g_NH[g_NH.Row, "MaNhom"].ToString());
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                txt_TenNhom.Text = table.Rows[0]["TenNhom"].ToString();
                txt_MaNhom.Text = table.Rows[0]["MaNhom"].ToString();
                chk_Nhom.Checked = Conversions.ToBoolean(table.Rows[0]["SuDung"]);
                txt_MaNhom.Enabled = txt_TenNhom.Enabled = chk_Nhom.Enabled = false;
                //Lấy dữ liệu hàng hóa theo nhóm
                DataTable table1;
                try
                {
                    Common.obj.Add_NewCommand("Select MaHang, TenHang, DonGia1, DonGia2, DonGia3, DonGia4, LoaiHang from DM_HangHoa where SuDung = @SuDung and MaNhom = @MaNhom", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 1);
                    Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, g_NH[g_NH.Row, "MaNhom"].ToString());
                    table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                }
                catch (Exception ex1)
                {
                    Exception ex = ex1;
                    ProjectData.SetProjectError(ex);
                    throw ex;
                }
                g_HH.DataSource = table1;
                FillColorGrid_g_HH();
                g_HH.Redraw = true;
                g_HH.Show();
            }
        }

        private void g_HH_MouseDown(object sender, MouseEventArgs e)
        {
            if (g_HH.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để chọn !", "Thông báo");
                return;
            }
            else
            {
                addnewNH = false;
                
                Common.obj.Add_NewCommand("Select * from DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, g_HH[g_HH.Row, "MaHang"].ToString());
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                txt_TenHang.Text = table.Rows[0]["TenHang"].ToString();
                txt_MaHang.Text = table.Rows[0]["MaHang"].ToString();
                txt_MaNhom.Text = table.Rows[0]["MaNhom"].ToString();
                txt_GiaVon.Text = table.Rows[0]["GiaVon"].ToString();
                txt_SLToiThieu.Text = table.Rows[0]["SLToiThieu"].ToString();
                txt_DonGia1.Text = table.Rows[0]["DonGia1"].ToString();
                txt_DonGia2.Text = table.Rows[0]["DonGia2"].ToString();
                txt_DonGia3.Text = table.Rows[0]["DonGia3"].ToString();
                txt_DonGia4.Text = table.Rows[0]["DonGia4"].ToString();
                chk_Hang.Checked = Conversions.ToBoolean(table.Rows[0]["SuDung"]);
                cbo_CTrinh.Text = table.Rows[0]["LoaiHang"].ToString();

                //Lấy Tên nhóm
                Common.obj.Add_NewCommand("Select MaNhom, TenNhom from DM_NhomHang where MaNhom = @MaNhom", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, txt_MaNhom.Text);
                DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                txt_TenNhom.Text = table1.Rows[0]["TenNhom"].ToString();
                txt_MaHang.Enabled = txt_TenHang.Enabled = txt_DonGia1.Enabled = txt_DonGia2.Enabled = txt_DonGia3.Enabled = txt_DonGia4.Enabled = txt_SLToiThieu.Enabled = txt_GiaVon.Enabled = chk_Hang.Enabled = false;

            }
        }

        private void GetData_DSNH()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaNhom, TenNhom from DM_NhomHang where SuDung = @SuDung", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 1);
                dtDSNH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }

        }
        private void GetData_DSNH1()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaNhom, TenNhom from DM_NhomHang where SuDung = @SuDung", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 0);
                dtDSNH1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private void GetData_DSHH()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaHang, TenHang, DonGia1, DonGia2, DonGia3, DonGia4, LoaiHang from DM_HangHoa where SuDung = @SuDung", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 1);
                dtDSHH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }

        }
        private void GetData_DSHH1()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaHang, TenHang, DonGia1, DonGia2, DonGia3, DonGia4, LoaiHang from DM_HangHoa where SuDung = @SuDung", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.NVarChar, 0);
                dtDSHH1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private void FillColorGrid_g_NH()
        {
            try
            {
                g_NH.Cols[1].Caption = "Mã Nhóm";
                g_NH.Cols[1].Width = 100;
                g_NH.Cols[2].Caption = "Tên Nhóm";
                g_NH.Cols[2].Width = 100;
                g_NH.Rows[0].Height = 30;
                g_NH.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_NH.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_NH.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_NH.Rows[i].Height = 30;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }
        private void FillColorGrid_g_HH()
        {
            try
            {
                g_HH.Cols[1].Caption = "Mã Hàng";
                g_HH.Cols[1].Width = 80;
                g_HH.Cols[1].Visible = true;
                g_HH.Cols[2].Caption = "Tên Hàng";
                g_HH.Cols[2].Width = 200;
                g_HH.Cols[3].Caption = "Giá 1";
                g_HH.Cols[3].Width = 65;
                g_HH.Cols[3].Format = "##,##0";
                g_HH.Cols[4].Caption = "Giá 2";
                g_HH.Cols[4].Width = 65;
                g_HH.Cols[4].Format = "##,##0";
                g_HH.Cols[5].Caption = "Giá 3";
                g_HH.Cols[5].Width = 65;
                g_HH.Cols[5].Format = "##,##0";
                g_HH.Cols[6].Caption = "Giá 4";
                g_HH.Cols[6].Width = 65;
                g_HH.Cols[6].Format = "##,##0";
                g_HH.Cols[7].Caption = "Loại hàng";
                g_HH.Rows[0].Height = 30;
                g_HH.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_HH.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_HH.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_HH.Rows[i].Height = 30;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Find_DSHH();
            }
        }
        private void Find_DSHH()
        {
            try
            {
                Common.obj.Add_NewCommand("Select MaHang, TenHang, DonGia1, DonGia2, DonGia3, DonGia4, LoaiHang from DM_HangHoa where SuDung = @SuDung and (MaNhom = @MaNhom or @MaNhom = '') and ((MaHang like '%' + @Find + '%') or (TenHang like '%' + @Find + '%'))", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@SuDung", SqlDbType.Bit, Conversions.ToInteger(chk_Hang_BC.Checked));
                Common.obj.Add_MyParametersCommand("@Find", SqlDbType.NVarChar, txt_Find.Text);
                Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_Nhom_BC.SelectedValue.ToString());
                dtDSHH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            g_HH.DataSource = dtDSHH;
            FillColorGrid_g_HH();
            g_HH.Show();
        }

        private void cbo_Nhom_BC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Find_DSHH();
        }
    }
}
