using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
    public partial class TK_NhapKho : Form
    {
        bool fl_new = true;
        DataTable dtInfo;
        DataTable dtItem;
        DataTable dtBC;
        public TK_NhapKho()
        {
            InitializeComponent();
        }

        private void TK_NhapKho_Load(object sender, EventArgs e)
        {
            Common.obj.Add_NewCommand("Select Code = MaNX, Name = TenNX from TK_MaNX where LoaiNX = N'Nhap'", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            cbo_LoaiNX.aaDataSource = table;
            cbo_LoaiNX.aaValueCode = "NH";

            LoadCBO_NCC();

            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1 and NV = 0", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_KH_BC.aaDataSource = table1;
            cbo_KH_BC.aaSelectIndex = 0;

            Common.obj.Add_NewCommand("Select Code = MaHang, Name = TenHang from DM_HangHoa where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table3 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row3 = table3.NewRow();
            row3["Code"] = "";
            row3["Name"] = "";
            table3.Rows.InsertAt(row3, 0);
            cbo_HangHoa.aaDataSource = table3;
            cbo_HangHoa.aaSelectIndex = 0;

            DataTable table4 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row4 = table4.NewRow();
            row4["Code"] = "";
            row4["Name"] = "";
            table4.Rows.InsertAt(row4, 0);
            cbo_HangHoa_BC.aaDataSource = table4;
            cbo_HangHoa_BC.aaSelectIndex = 0;

            Common.obj.Add_NewCommand("Select Code = MaNX, Name = TenNX from TK_MaNX where LoaiNX = N'Nhap'", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table5 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row5 = table5.NewRow();
            row5["Code"] = "";
            row5["Name"] = "";
            table5.Rows.InsertAt(row5, 0);
            cbo_LoaiNX_BC.aaDataSource = table5;
            cbo_LoaiNX_BC.aaSelectIndex = 0;

            Common.obj.Add_NewCommand("Select Code = MaKho, Name = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table6 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            cbo_Kho.aaDataSource = table6;
            cbo_Kho.aaValueCode = "KC";

            Common.obj.Add_NewCommand("Select Code = MaKho, Name = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table7 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row7 = table7.NewRow();
            row7["Code"] = "";
            row7["Name"] = "";
            table7.Rows.InsertAt(row7, 0);
            cbo_Kho_BC.aaDataSource = table7;
            cbo_Kho_BC.aaSelectIndex = 0;

            cbo_LoaiNX_aaItemSelected(null, null);

            GetData_Item("new", "999999999");
            g_Item.DataSource = dtItem;
            FillColorGrid_gItem();
            GetData_BC();
        }

        private void cbo_LoaiNX_aaItemSelected(object sender, EventArgs e)
        {
            ShowCongTo();

            if (cbo_LoaiNX.aaValueCode.ToString() == "NH" | cbo_LoaiNX.aaValueCode.ToString() == "NHDC")
            {
                LoadCBO_NCC();
            }
            else if (cbo_LoaiNX.aaValueCode.ToString() == "NHTL")
            {
                LoadCBO_KH();
            }
        }

        private void LoadCBO_NCC()
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1 and NCC = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_KH.aaDataSource = table1;
            cbo_KH.aaSelectIndex = 0;
        }

        private void ShowCongTo()
        {
            Common.obj.Add_NewCommand("sys_ShowCongto", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiNX.aaValueCode.ToString());
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            txt_MaPhieu.Text = table.Rows[0][0].ToString();
        }
        private void LoadCBO_KH()
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1 and KH = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_KH.aaDataSource = table1;
            cbo_KH.aaSelectIndex = 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbo_HangHoa.aaValueCode.ToString() != "")
            {
                if (txt_SL.Text != "0")
                {
                    if (txt_DonGia.Text != "0")
                    {
                        Common.obj.Add_NewCommand("Select * from DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa.aaValueCode.ToString());
                        DataTable dataHangHoaByBarCode = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                        if (dataHangHoaByBarCode.Rows.Count == 0)
                        {
                            cbo_HangHoa.aaValueName = "";
                            cbo_HangHoa.aaValueCode = "";
                        }
                        else
                        {

                            DataRow row = dtItem.NewRow();
                            row["MaHang"] = dataHangHoaByBarCode.Rows[0]["MaHang"];
                            row["TenHang"] = dataHangHoaByBarCode.Rows[0]["TenHang"];
                            row["SL"] = Interaction.IIf(Conversions.ToDouble(txt_SL.Text) == 0.0, 1, txt_SL.Text);
                            row["DonGia"] = Interaction.IIf(Conversions.ToDouble(txt_DonGia.Text) == 0.0, 0, txt_DonGia.Text); ;
                            row["ThanhTien"] = Operators.MultiplyObject(row["SL"], row["DonGia"]);
                            row["MaPhieu"] = txt_MaPhieu.Text;
                            dtItem.Rows.Add(row);
                            g_Item.DataSource = dtItem;
                            FillColorGrid_gItem();
                            TinhTongTien();
                            //cbo_HangHoa.aaValueName = "";
                            //cbo_HangHoa.aaValueCode = "";
                            txt_DonGia.Text = "0";
                            txt_SL.Text = "1";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá !", "Thông báo");
                        return;
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
                MessageBox.Show("Vui lòng chọn hàng hóa nhập kho !", "Thông báo");
                return;
            }

            
        }

        private void GetData_Item(string Type, string MaKH)
        {
            Common.obj.Add_NewCommand("TK_GetData_NhapHang", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, Type);
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, MaKH);
            Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
            dtItem = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            g_Item.DataSource = dtItem;
            FillColorGrid_gItem();
            TinhTongTien();
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
                g_Item.Cols[3].Caption = "SL";
                g_Item.Cols[3].Width = 60;
                g_Item.Cols[3].Format = "##,##0.##";
                g_Item.Cols[3].AllowEditing = true;
                g_Item.Cols[4].Caption = "Đơn giá";
                g_Item.Cols[4].Width = 80;
                g_Item.Cols[4].AllowEditing = true;
                g_Item.Cols[4].Format = "##,##0.##";
                g_Item.Cols[5].Caption = "Thành tiền";
                g_Item.Cols[5].Width = 100;
                g_Item.Cols[5].AllowEditing = false;
                g_Item.Cols[5].Format = "##,###,###,##0.##";
                g_Item.Cols[6].Caption = "Ghi Chú";
                g_Item.Cols[6].Width = 100;
                g_Item.Cols[6].AllowEditing = false;
                g_Item.Cols[6].Visible = false;
                g_Item.Cols[7].Caption = "Mã Phiếu";
                g_Item.Cols[7].Width = 100;
                g_Item.Cols[7].AllowEditing = false;
                g_Item.Cols[7].Visible = false;
                g_Item.Rows[0].Height = 30;
                g_Item.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_Item.Styles.EmptyArea.BackColor = Color.White;
                int num2 = g_Item.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    g_Item.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }
        private void TinhTongTien()
        {
            try
            {
                txt_TongSL.Text = Conversions.ToString(sys_Utility.sys_Utility.Sum_Col(dtItem, "SL"));
                txt_TongTien.Text = Conversions.ToString(sys_Utility.sys_Utility.Sum_Col(dtItem, "ThanhTien"));

            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        private void g_Item_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (g_Item.Row > 0)
            {
                if ((g_Item.Cols[g_Item.Col].Name.ToLower() == "SL".ToLower()) | (g_Item.Cols[g_Item.Col].Name.ToLower() == "DonGia".ToLower()))
                {
                    double num2 = 0;
                    double right = Conversions.ToDouble(Operators.MultiplyObject(g_Item[g_Item.Row, "SL"], g_Item[g_Item.Row, "DonGia"]));
                    g_Item[g_Item.Row, "ThanhTien"] = right;

                }
                TinhTongTien();
            }
        }

        private void cbo_HangHoa_aaItemSelected(object sender, EventArgs e)
        {
            if (cbo_HangHoa.aaValueCode.ToString() != "")
            {
                Common.obj.Add_NewCommand("Select * from DM_HangHoa where MaHang = @MaHang", sys_ConData.sys_ConData.cmdType.Query);
                Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa.aaValueCode.ToString());
                DataTable dataHangHoaByBarCode = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                txt_DonGia.Text = dataHangHoaByBarCode.Rows[0]["GiaVon"].ToString();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ShowCongTo();
            cbo_Kho.Enabled = cbo_HangHoa.Enabled = cbo_LoaiNX.Enabled = cbo_KH.Enabled = cbo_HangHoa.Enabled = btn_Add.Enabled = dtp_NgayLap.Enabled = dtp_NgayGiao.Enabled = true;
            fl_new = true;
            g_Item.Enabled = true;
            GetData_Item("new", "999999999");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            cbo_Kho.Enabled = cbo_HangHoa.Enabled = cbo_LoaiNX.Enabled = cbo_KH.Enabled = cbo_HangHoa.Enabled = btn_Add.Enabled = dtp_NgayLap.Enabled = dtp_NgayGiao.Enabled = true;
            g_Item.Enabled = true;
            fl_new = false;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        { DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Đơn hàng nhập này?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cbo_Kho.Enabled = cbo_HangHoa.Enabled = cbo_LoaiNX.Enabled = cbo_KH.Enabled = cbo_HangHoa.Enabled = btn_Add.Enabled = dtp_NgayLap.Enabled = dtp_NgayGiao.Enabled =false;
                if (txt_MaPhieu.Text != "")
                {
                    try
                    {
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("Update TK_DonHangNhap set Huy = 1 where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
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
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            g_Item.Enabled = false;
            cbo_Kho.Enabled = cbo_HangHoa.Enabled = cbo_LoaiNX.Enabled = cbo_KH.Enabled = cbo_HangHoa.Enabled = btn_Add.Enabled = dtp_NgayLap.Enabled = dtp_NgayGiao.Enabled = false;
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
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiNX.aaValueCode.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, cbo_LoaiNX.aaValueCode.ToString());
                        DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Insert into TK_DonHangNhap (MaPhieu, NgayLap, MaKH, NgayGiao, MaKho, LoaiNX) values (@MaPhieu, @NgayLap, @MaKH, @NgayGiao, @MaKho, @LoaiNX)", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.Add_MyParametersCommand("@LoaiNX", SqlDbType.NVarChar, cbo_LoaiNX.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_Kho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtp_NgayGiao.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu from TK_DonHangNhap_Item", sys_ConData.sys_ConData.cmdType.Query);
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
                        Common.obj.Add_NewCommand("Update TK_DonHangNhap set NgayLap = @NgayLap, MaKH = @MaKH, NgayGiao = @NgayGiao, MaKho = @MaKho, LoaiNX = @LoaiNX where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@LoaiNX", SqlDbType.NVarChar, cbo_LoaiNX.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_Kho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtp_NgayLap.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtp_NgayGiao.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("Delete TK_DonHangNhap_Item where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu from TK_DonHangNhap_Item", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.UpdateTable(Common.obj.Get_NewCommand(), table2);

                        MessageBox.Show("Lưu thành công", "Thông báo");
                        Common.obj.CommitTransaction();
                    }
                    GetData_BC();
                }
            }

        }
        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_BK_DonHangNhap", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dptTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@LoaiNX", SqlDbType.NVarChar, cbo_LoaiNX_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_Kho_BC.aaValueCode.ToString());
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

        private void g_BC_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_Kho.Enabled = cbo_HangHoa.Enabled = cbo_LoaiNX.Enabled = cbo_KH.Enabled = cbo_HangHoa.Enabled = btn_Add.Enabled = dtp_NgayLap.Enabled = dtp_NgayGiao.Enabled = false;
            g_Item.Enabled = false;
            if (g_BC.Rows.Count > 1)
            {
                if (g_BC[g_BC.Row, "MaPhieu"].ToString() != "")
                {
                    txt_MaPhieu.Text = g_BC[g_BC.Row, "MaPhieu"].ToString();
                    Common.obj.Add_NewCommand("Select * from TK_DonHangNhap where MaPhieu = @MaPhieu", sys_ConData.sys_ConData.cmdType.Query);
                    Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu.Text);
                    DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                    cbo_LoaiNX.aaValueCode = table.Rows[0]["LoaiNX"].ToString();
                    cbo_Kho.aaValueCode = table.Rows[0]["MaKho"].ToString();
                    cbo_KH.aaValueCode = table.Rows[0]["MaKH"].ToString();
                    dtp_NgayLap.Text = table.Rows[0]["NgayLap"].ToString();
                    dtp_NgayGiao.Text = table.Rows[0]["NgayGiao"].ToString();

                    GetData_Item("new", g_BC[g_BC.Row, "MaKH"].ToString());
                }
            }
        }

        private void txt_SL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add_Click(null, null);
                
            }
        }

        private void txt_DonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add_Click(null, null);
                
            }
        }
        

        private void dptTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_LoaiNX_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void txt_SL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbo_HangHoa.Focus();
            }
        }

        private void cbo_HangHoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SL.Focus();
            }
        }
    }
}
