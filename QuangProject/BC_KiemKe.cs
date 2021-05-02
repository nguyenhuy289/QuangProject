using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuangProject
{
    public partial class BC_KiemKe : Form
    {
        DataTable dtBC;
        public BC_KiemKe()
        {
            InitializeComponent();
        }

        private void BC_KiemKe_Load(object sender, EventArgs e)
        {
            Common.obj.Add_NewCommand("Select Code = MaNhom, [Name] = TenNhom from DM_NhomHang where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = table.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            table.Rows.InsertAt(row, 0);
            cbo_MaNhom.aaDataSource = table;
            cbo_MaNhom.aaSelectIndex = 0;


            Common.obj.Add_NewCommand("Select Code = MaHang, [Name] = TenHang from DM_HangHoa where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_HangHoa.aaDataSource = table1;
            cbo_HangHoa.aaSelectIndex = 0;

            Common.obj.Add_NewCommand("Select Code = MaKho, Name = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table2 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row2 = table2.NewRow();
            row2["Code"] = "";
            row2["Name"] = "";
            table2.Rows.InsertAt(row2, 0);
            cbo_MaKho.aaDataSource = table2;
            cbo_MaKho.aaSelectIndex = 0;

            GetData_BC();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_KiemKe", sys_ConData.sys_ConData.cmdType.Store);
            //Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_MaKho.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_MaNhom.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã Nhóm";
                g_BC.Cols[1].Width = 100;
                g_BC.Cols[1].Visible = false;
                g_BC.Cols[2].Caption = "Tên Nhóm";
                g_BC.Cols[2].Width = 300;
                g_BC.Cols[2].Visible = false;
                g_BC.Cols[3].Caption = "Mã Hàng";
                g_BC.Cols[3].Width = 80;
                g_BC.Cols[3].AllowEditing = false;
                g_BC.Cols[4].Caption = "Tên Hàng";
                g_BC.Cols[4].Width = 250;
                g_BC.Cols[4].AllowEditing = false;
                g_BC.Cols[5].Caption = "Tồn kho";
                g_BC.Cols[5].Width = 100;
                g_BC.Cols[5].AllowEditing = false;
                g_BC.Cols[5].Format = "##,##0";
                g_BC.Cols[6].Visible = false;
                g_BC.Cols[7].Caption = "SL Thực tế";
                g_BC.Cols[7].AllowEditing = true;
                g_BC.Cols[7].Width = 100;
                g_BC.Cols[7].Format = "##,##0";
                g_BC.Cols[8].Caption = "Chênh lệch";
                g_BC.Cols[8].AllowEditing = false;
                g_BC.Cols[8].Width = 100;
                g_BC.Cols[8].Format = "##,##0";
                g_BC.Cols[9].Caption = "Kiểm kê";
                g_BC.Cols[9].AllowEditing = true;
                g_BC.Cols[10].Visible = false;
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_BC.Rows[i].Height = 25;
                }

                g_BC.Tree.Column = 4;
                g_BC.Tree.Style = TreeStyleFlags.Simple;
                int index = g_BC.Cols["SL"].Index;
                g_BC.Subtotal(AggregateEnum.Clear);
                g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index, "{0}");
                g_BC.Styles[CellStyleEnum.Subtotal0].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
                g_BC.Styles[CellStyleEnum.Subtotal1].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Brown;
                g_BC.Styles[CellStyleEnum.Subtotal1].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                g_BC.Styles[CellStyleEnum.Subtotal2].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Brown;
                g_BC.Styles[CellStyleEnum.Subtotal2].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                g_BC.Redraw = true;

            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }

        private void cbo_MaKho_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void g_BC_AfterEdit(object sender, RowColEventArgs e)
        {
            if(g_BC.Rows.Count > 1)
            {
                    double right = Conversions.ToDouble(Operators.SubtractObject(this.g_BC[this.g_BC.Row, "SLTT"], this.g_BC[this.g_BC.Row, "SL"]));
                    this.g_BC[this.g_BC.Row, "ChenhLech"] = right;
            }
        }

        private void btn_NhapDieuChinh_Click(object sender, EventArgs e)
        {
            if(cbo_MaKho.aaValueCode.ToString() != "")
            {
                Common.obj.Add_NewCommand("sys_ShowCongto", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "NHDC");
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                string txt_MaPhieu = table.Rows[0][0].ToString();
                try
                {
                    IEnumerator enumerator = default(IEnumerator);
                    DataTable dt = this.GetData_PNK();
                    try
                    {
                        enumerator = this.dtBC.Rows.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataRow current = (DataRow)enumerator.Current;
                            if ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(current["ChenhLech"])) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(current["KiemKe"]))) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(current["ChenhLech"], 0, false), Operators.CompareObjectEqual(current["KiemKe"], true, false))))
                            {
                                DataRow row = dt.NewRow();
                                row["MaHang"] = RuntimeHelpers.GetObjectValue(current["MaHang"]);
                                row["TenHang"] = RuntimeHelpers.GetObjectValue(current["TenHang"]);
                                row["SL"] = RuntimeHelpers.GetObjectValue(current["ChenhLech"]);
                                row["DonGia"] = RuntimeHelpers.GetObjectValue(current["GiaVon"]);
                                row["ThanhTien"] = Operators.MultiplyObject(row["SL"], row["DonGia"]);
                                row["MaPhieu"] = txt_MaPhieu;
                                dt.Rows.Add(row);
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    if(dt.Rows.Count > 0)
                    {
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("sys_SetCongto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "NHDC");
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "NHDC");
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Insert into TK_DonHangNhap (MaPhieu, NgayLap, MaKH, NgayGiao, MaKho, LoaiNX) values (@MaPhieu, @NgayLap, @MaKH, @NgayGiao, @MaKho, @LoaiNX)", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu);
                        Common.obj.Add_MyParametersCommand("@LoaiNX", SqlDbType.NVarChar, "NHDC");
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "DieuChinh");
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_MaKho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu from TK_DonHangNhap_Item", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.UpdateTable(Common.obj.Get_NewCommand(), dt);

                        MessageBox.Show("Nhập điều chỉnh thành công!", "Thông báo");
                        Common.obj.CommitTransaction();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để điều chỉnh", "Thông báo");
                    }

                    
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox("Lỗi:" + exception.Message, MsgBoxStyle.ApplicationModal, "Thong Bao");
                    ProjectData.ClearProjectError();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã kho để điều chỉnh", "Thông báo");
            }
            
        }

        private void btn_XuatDieuChinh_Click(object sender, EventArgs e)
        {
            if (cbo_MaKho.aaValueCode.ToString() != "")
            {
                Common.obj.Add_NewCommand("sys_ShowCongto", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "XHDC");
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

                string txt_MaPhieu = table.Rows[0][0].ToString();
                try
                {
                    IEnumerator enumerator = default(IEnumerator);
                    DataTable dt = this.GetData_PNK();
                    try
                    {
                        enumerator = this.dtBC.Rows.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataRow current = (DataRow)enumerator.Current;
                            if ((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(current["ChenhLech"])) & !Information.IsDBNull(RuntimeHelpers.GetObjectValue(current["KiemKe"]))) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(current["ChenhLech"], 0, false), Operators.CompareObjectEqual(current["KiemKe"], true, false))))
                            {
                                DataRow row = dt.NewRow();
                                row["MaHang"] = RuntimeHelpers.GetObjectValue(current["MaHang"]);
                                row["TenHang"] = RuntimeHelpers.GetObjectValue(current["TenHang"]);
                                row["SL"] = Conversions.ToString((-1) * Conversions.ToDouble(RuntimeHelpers.GetObjectValue(current["ChenhLech"])));
                                row["DonGia"] = RuntimeHelpers.GetObjectValue(current["GiaVon"]);
                                row["ThanhTien"] = Operators.MultiplyObject(row["SL"], row["DonGia"]);
                                row["MaPhieu"] = txt_MaPhieu;
                                dt.Rows.Add(row);
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    if (dt.Rows.Count > 0)
                    {
                        Common.obj.BeginTransaction();
                        Common.obj.Add_NewCommand("sys_SetCongto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "XHDC");
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        Common.obj.Add_NewCommand("sys_Get_Congto", sys_ConData.sys_ConData.cmdType.Store);
                        Common.obj.Add_MyParametersCommand("@MaCongTo", SqlDbType.NVarChar, "XHDC");
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Insert into TK_DonHangXuat (MaPhieu, NgayLap, MaKH, NgayGiao, MaKho, LoaiNX) values (@MaPhieu, @NgayLap, @MaKH, @NgayGiao, @MaKho, @LoaiNX)", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, txt_MaPhieu);
                        Common.obj.Add_MyParametersCommand("@LoaiNX", SqlDbType.NVarChar, "XHDC");
                        Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "DieuChinh");
                        Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, cbo_MaKho.aaValueCode.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayLap", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
                        Common.obj.Add_MyParametersCommand("@NgayGiao", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
                        Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());

                        Common.obj.Add_NewCommand("Select MaHang, SL, DonGia, ThanhTien, GhiChu, MaPhieu from TK_DonHangXuat_Item", sys_ConData.sys_ConData.cmdType.Query);
                        Common.obj.UpdateTable(Common.obj.Get_NewCommand(), dt);

                        MessageBox.Show("Xuất điều chỉnh thành công!", "Thông báo");
                        Common.obj.CommitTransaction();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để điều chỉnh", "Thông báo");
                    }


                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox("Lỗi:" + exception.Message, MsgBoxStyle.ApplicationModal, "Thong Bao");
                    ProjectData.ClearProjectError();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã kho để điều chỉnh", "Thông báo");
            }
        }

        private DataTable GetData_PNK()
        {
            DataTable table;
            try
            {
                Common.obj.Add_NewCommand("TK_GetData_NhapHang", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "new");
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, "Nothing1234");
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "NguyenHuy");
                table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
            return table;
        }
        private DataTable GetData_PXK()
        {
            DataTable table;
            try
            {
                Common.obj.Add_NewCommand("TK_GetData_XuatHang", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "new");
                Common.obj.Add_MyParametersCommand("@MaPhieu", SqlDbType.NVarChar, "Nothing1234");
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "NguyenHuy");
                table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
            return table;
        }
    }
}
