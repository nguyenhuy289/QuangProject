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
using sys_Utility;
using System.Collections;
using FastReport;

namespace QuangProject
{
    public partial class BH_BanHang : Form
    {
        bool fl_new = true;
        DataTable dtInfo;
        DataTable dtItem;
        DataTable dtBC;
        public BH_BanHang()
        {
            InitializeComponent();
            Common.obj = new sys_ConData.sys_ConData();
        }
        private void ShowCongTo()
        {
            Common.obj.Add_NewCommand("sys_ShowCongTo", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "BH");
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            txt_MaPhieu.Text = table.Rows[0][0].ToString();
        }
        private void BH_BanHang_Load(object sender, EventArgs e)
        {
            GetData_BC();
            try
            {
                
                Common.obj.Add_NewCommand("Select Code = MaKH, [Name] = TenKH from DM_KhachHang where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row = table.NewRow();
                row["Code"] = "";
                row["Name"] = "";
                table.Rows.InsertAt(row, 0);
                cbo_KH.aaDataSource = table;
                cbo_KH.aaSelectIndex = 0;

                DataRow row1 = table1.NewRow();
                row1["Code"] = "";
                row1["Name"] = "";
                table1.Rows.InsertAt(row1, 0);
                cbo_KH_BC.aaDataSource = table1;
                cbo_KH_BC.aaSelectIndex = 0;
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }

            try
            {

                Common.obj.Add_NewCommand("Select Code = MaKho, [Name] = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                cbo_Kho.aaDataSource = table;
                cbo_Kho.aaValueCode = "KC";
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }

            try
            {
                Common.obj.Add_NewCommand("Select Code = MaHang, [Name] = TenHang from DM_HangHoa where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row = table.NewRow();
                row["Code"] = "";
                row["Name"] = "";
                table.Rows.InsertAt(row, 0);
                cbo_HH.aaDataSource = table;
                cbo_HH.aaSelectIndex = 0;

                DataRow row1 = table1.NewRow();
                row1["Code"] = "";
                row1["Name"] = "";
                table1.Rows.InsertAt(row1, 0);
                cbo_HH_BC.aaDataSource = table1;
                cbo_HH_BC.aaSelectIndex = 0;
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }

            try
            {
                Common.obj.Add_NewCommand("Select Code = MaNhom, [Name] = TenNhom from DM_NhomHang where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row = table.NewRow();
                row["Code"] = "";
                row["Name"] = "";
                table.Rows.InsertAt(row, 0);
                cbo_NH_BC.aaDataSource = table;
                cbo_NH_BC.aaSelectIndex = 0;
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            GetData_Item("new","");
            g_Item.DataSource = dtItem;
            FillColorGrid_gItem();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_BK_DonHangBan", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dptTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_NH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HH_BC.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã phiếu";
                g_BC.Cols[1].Width = 180;
                g_BC.Cols[1].AllowEditing = false;
                g_BC.Cols[2].Caption = "Ngày ";
                g_BC.Cols[2].Width = 100;
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
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            fl_new = true;
            ShowCongTo();
            cbo_Kho.Enabled = cbo_KH.Enabled = cbo_HH.Enabled = txt_SL.Enabled = simpleButton2.Enabled = simpleButton1.Enabled = true;
            GetData_Item("new","");
            g_Item.DataSource = dtItem;
            FillColorGrid_gItem();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cbo_HH.aaValueCode.ToString() != "")
            {
                if (txt_SL.Text != "0")
                {
                        Common.obj.Add_NewCommand("Select * from DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HH.aaValueCode.ToString());
                        DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    if (table.Rows.Count == 0)
                    {
                        cbo_HH.aaValueName = "";
                        cbo_HH.aaValueCode = "";
                    }
                    else
                    {
                        DataRow row = this.dtItem.NewRow();
                        row["MaHang"] = table.Rows[0]["MaHang"];
                        row["TenHang"] = table.Rows[0]["TenHang"];
                        row["SL"] = Interaction.IIf(Conversions.ToDouble(this.txt_SL.Text) == 0.0, 1, txt_SL.Text);
                        row["GiaBan"] = table.Rows[0]["GiaBan"];
                        row["CK"] = 0;
                        row["TienCK"] = 0;
                        row["TongTien"] = Operators.MultiplyObject(row["SL"], row["GiaBan"]);
                        row["SoHD"] = this.txt_MaPhieu.Text;
                        dtItem.Rows.Add(row);
                        g_Item.DataSource = dtItem;
                        FillColorGrid_gItem();
                        TinhTongTien();
                        cbo_HH.aaValueName = "";
                        cbo_HH.aaValueCode = "";
                        txt_SL.Text = "1";
                        cbo_HH.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng !", "Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Hàng hóa !", "Thông báo");
                return;
            }
        }
        private void FillColorGrid_gItem()
        {
            try
            {
                g_Item.Cols[1].Caption = "Mã hàng";
                g_Item.Cols[1].Width = 70;
                g_Item.Cols[1].AllowEditing = false;
                g_Item.Cols[2].Caption = "Tên hàng";
                g_Item.Cols[2].Width = 300;
                g_Item.Cols[2].AllowEditing = false;
                g_Item.Cols[3].Caption = "Nhu cầu";
                g_Item.Cols[3].Width = 80;
                g_Item.Cols[3].Format = "##,##0.##";
                g_Item.Cols[3].AllowEditing = false;
                g_Item.Cols[4].Caption = "Tồn kho";
                g_Item.Cols[4].Width = 80;
                g_Item.Cols[4].Format = "##,##0.##";
                g_Item.Cols[4].AllowEditing = false;
                g_Item.Cols[5].Caption = "SL";
                g_Item.Cols[5].Width = 60;
                g_Item.Cols[5].Format = "##,##0.##";
                g_Item.Cols[5].AllowEditing = true;
                g_Item.Cols[6].Caption = "Đơn giá";
                g_Item.Cols[6].Width = 80;
                g_Item.Cols[6].AllowEditing = true;
                g_Item.Cols[6].Format = "##,##0.##";
                g_Item.Cols[7].Caption = "Thành tiền";
                g_Item.Cols[7].Width = 100;
                g_Item.Cols[7].AllowEditing = true;
                g_Item.Cols[7].Format = "##,##0";
                g_Item.Cols[8].Caption = "Ghi Chú";
                g_Item.Cols[8].Width = 100;
                g_Item.Cols[8].AllowEditing = true;
                g_Item.Cols[8].Visible = true;
                g_Item.Cols[9].Caption = "Mã Phiếu";
                g_Item.Cols[9].Width = 100;
                g_Item.Cols[9].AllowEditing = false;
                g_Item.Cols[9].Visible = false;
                g_Item.Cols[10].Caption = "Pt giảm giá";
                g_Item.Cols[10].Visible = false;
                g_Item.Rows[0].Height = 30;
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
        private void GetData(string SoHD)
        {
            //Common.obj.Add_NewCommand("Select MaKH, NgayLap, SL, TongTien, GhiChu from BH_DonHangBan_Info where SoHD = @SoHD", sys_ConData.sys_ConData.cmdType.Query);
            //Common.obj.Add_MyParametersCommand("@SoHD", SqlDbType.NVarChar, SoHD);
            //dtInfo = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            //Common.obj.Add_NewCommand("Select a.MaHang, b.TenHang, NC = 0, SL, TK = 0, a.GiaBan, CK, TienCK, TongTien, GhiChu, SoHD from BH_DonHangBan_Items a left outer join DM_HangHoa b on a.MaHang = b.MaHang where SoHD = @SoHD", sys_ConData.sys_ConData.cmdType.Query);
            //Common.obj.Add_MyParametersCommand("@SoHD", SqlDbType.NVarChar, SoHD);
            //dtItem = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
        }
        private void TinhTongTien()
        {
            try
            {
                this.txt_TongSL.Text = Conversions.ToString(sys_Utility.sys_Utility.Sum_Col(this.dtItem, "SL"));
                this.txt_TongTien.Text = Conversions.ToString(sys_Utility.sys_Utility.Sum_Col(this.dtItem, "ThanhTien"));
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetData_Item("new" , cbo_KH.aaValueCode.ToString());
            Get_CongNo(cbo_KH.aaValueCode.ToString());
        }
        private void Get_CongNo(string MaKH)
        {
            try
            {
                Common.obj.Add_NewCommand("Select KH, NCC from DM_KhachHang where MaKH = @MaKH", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, MaKH);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                if (table.Rows[0]["KH"].ToString() == "True" & table.Rows[0]["NCC"].ToString() == "False")
                {
                    Common.obj.Add_NewCommand("BC_LayCongNoDK_PhaiThu", sys_ConData.sys_ConData.cmdType.Store);
                    Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "HIENTAI");
                    Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, MaKH);
                    Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, DateTime.Today.ToString("yyyy-MM-dd"));
                    DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    if (table1.Rows.Count == 0)
                    {
                        txt_NoCu.Text = "0";
                    }
                    else
                    {
                        txt_NoCu.Text = "-" + table1.Rows[0]["DuDK"].ToString();
                    }
                }
                else if (table.Rows[0]["KH"].ToString() == "False" & table.Rows[0]["NCC"].ToString() == "True")
                {
                    Common.obj.Add_NewCommand("BC_LayCongNoDK_PhaiTra", sys_ConData.sys_ConData.cmdType.Store);
                    Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "HIENTAI");
                    Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, MaKH);
                    Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, DateTime.Today.ToString("yyyy-MM-dd"));
                    DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    if(table1.Rows.Count == 0)
                    {
                        txt_NoCu.Text = "0";
                    }
                    else
                    {
                        txt_NoCu.Text = "-" + table1.Rows[0]["DuDK"].ToString();
                    }
                    
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private void GetData_Item(string Type, string MaKH)
        {
            Common.obj.Add_NewCommand("BH_GetData_tu_DonHangCho", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, Type);
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, MaKH);
            Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
            dtItem = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            g_Item.DataSource = dtItem;
            FillColorGrid_gItem();
            TinhTongTien();



        }

        private void sg_Grid2_Click(object sender, EventArgs e)
        {
            if (g_BC.Rows.Count > 1)
            {
                if (g_BC[g_BC.Row, "MaPhieu"].ToString() != "")
                {
                    g_Item.AllowEditing = false;
                    txt_MaPhieu.Text = g_BC[g_BC.Row, "MaPhieu"].ToString();
                    Common.obj.Add_NewCommand("Select * from BH_DonHangBan where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                    dtInfo = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    cbo_Kho.aaValueCode = dtInfo.Rows[0]["MaKho"].ToString();
                    cbo_KH.aaValueCode = dtInfo.Rows[0]["MaKH"].ToString();
                    dtp_NgayLap.Text = dtInfo.Rows[0]["NgayLap"].ToString();
                    dtp_NgayGiao.Text = dtInfo.Rows[0]["NgayGiao"].ToString();

                    GetData_Item("edit", g_BC[g_BC.Row, "MaPhieu"].ToString());

                    Get_CongNo(cbo_KH.aaValueCode.ToString());
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (fl_new == true)
            {
                if (txt_MaPhieu.Text != "")
                {
                    if (g_Item.Rows.Count > 0)
                    {
                        DataTable table2 = dtItem.Copy();
                        table2.AcceptChanges();
                        IEnumerator enumerator4 = default(IEnumerator);
                        try
                        {
                            enumerator4 = table2.Rows.GetEnumerator();
                            while (enumerator4.MoveNext())
                            {
                                ((DataRow)enumerator4.Current).SetAdded();
                            }
                        }
                        finally
                        {
                            if (enumerator4 is IDisposable)
                            {
                                (enumerator4 as IDisposable).Dispose();
                            }
                        }
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("sys_SetCongto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "BH");
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "BH");
                        DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Insert into BH_DonHangBan (MaPhieu, NgayLap, MaKH, NgayGiao, MaKho) values (@MaPhieu, @NgayLap, @MaKH, @NgayGiao, @MaKho)", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_Kho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtp_NgayGiao.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu, PTGiamGia from BH_DonHangBan_Item", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.UpdateTable(Common.obj.Get_NewCommand(), table2);

                        MessageBox.Show("Lưu thành công", "Thông báo");
                        Common.obj.CommitTransaction();

                    }
                    GetData_BC();
                }
            }
            else
            {
                if (txt_MaPhieu.Text != "")
                {
                    if (g_Item.Rows.Count > 0)
                    {
                        DataTable table2 = dtItem.Copy();
                        table2.AcceptChanges();
                        IEnumerator enumerator4 = default(IEnumerator);
                        try
                        {
                            enumerator4 = table2.Rows.GetEnumerator();
                            while (enumerator4.MoveNext())
                            {
                                ((DataRow)enumerator4.Current).SetAdded();
                            }
                        }
                        finally
                        {
                            if (enumerator4 is IDisposable)
                            {
                                (enumerator4 as IDisposable).Dispose();
                            }
                        }
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("Update BH_DonHangBan set NgayLap = @NgayLap, MaKH = @MaKH, NgayGiao = @NgayGiao, MaKho = @MaKho where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_Kho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtp_NgayGiao.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("Delete BH_DonHangBan_Item where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu from BH_DonHangBan_Item", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.UpdateTable(Common.obj.Get_NewCommand(), table2);

                        MessageBox.Show("Lưu thành công", "Thông báo");
                        Common.obj.CommitTransaction();
                    }
                    GetData_BC();
                }
            }
            cbo_Kho.Enabled = cbo_KH.Enabled = cbo_HH.Enabled = txt_SL.Enabled = simpleButton2.Enabled = simpleButton1.Enabled = false;
            Common.obj.Add_NewCommand("Select * from BH_DonHangBan where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
            dtInfo = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
        }

        private void cbo_KH_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dptTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        { DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Đơn hàng bán này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (txt_MaPhieu.Text != "")
                {
                    if (g_Item.Rows.Count > 0)
                    {
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("Update BH_DonHangBan set Huy = 1 where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.CommitTransaction();
                    }
                    GetData_BC();
                }
            }
            cbo_Kho.Enabled = cbo_KH.Enabled = cbo_HH.Enabled = txt_SL.Enabled = simpleButton2.Enabled = simpleButton1.Enabled = false;
        }

        private void g_Item_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (this.g_Item.Row > 0)
            {
                if ((this.g_Item.Cols[this.g_Item.Col].Name.ToLower() == "SL".ToLower()) | (this.g_Item.Cols[this.g_Item.Col].Name.ToLower() == "DonGia".ToLower()))
                {
                    double num2 = 0;
                    double right = Conversions.ToDouble(Operators.MultiplyObject(this.g_Item[this.g_Item.Row, "SL"], this.g_Item[this.g_Item.Row, "DonGia"]));
                    this.g_Item[this.g_Item.Row, "ThanhTien"] = right;
                    try
                    {
                        this.TinhTongTien();
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        throw ex;
                    }
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            cbo_Kho.Enabled = cbo_KH.Enabled = cbo_HH.Enabled = txt_SL.Enabled = simpleButton2.Enabled = simpleButton1.Enabled = true;
            fl_new = false;
            g_Item.AllowEditing = true;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName;
                fileName = Application.StartupPath + @"\rpt_BH_BanHang.frx";
                DataSet data = new DataSet();
                data.Clear();
                Report report = new Report();
                data.Tables.Add(dtInfo);
                data.Tables.Add(dtItem);
                report.Load(fileName);
                report.RegisterData(data);
                int num4 = data.Tables.Count - 1;
                for (int i = 0; i <= num4; i++)
                {
                    report.GetDataSource(data.Tables[i].TableName).Enabled = true;
                }
                //Check Sửa mẫu in hay không
                if (checkBox1.Checked == false)
                {
                    //Check có dữ liệu để in hay không
                    if (dtItem.Rows.Count > 0)
                    {
                        report.PrintSettings.ShowDialog = false;
                        report.Show();
                    }
                }
                else
                {
                    report.Design();
                }
                data.Tables.Remove(dtInfo);
                data.Tables.Remove(dtItem);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.Cursor = Cursors.Default;
                throw exception;
            }
        }
    }
}
