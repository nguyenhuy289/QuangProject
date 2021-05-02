using C1.Win.C1FlexGrid;
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
    public partial class BC_ChiTietHangTheoNhom : Form
    {
        DataTable dtBC;
        public BC_ChiTietHangTheoNhom()
        {
            InitializeComponent();
        }

        private void BC_ChiTietHangTheoNhom_Load(object sender, EventArgs e)
        {
            try
            {

                Common.obj.Add_NewCommand("Select Code = MaKH, [Name] = TenKH from DM_KhachHang where SuDung = 1 and KH = 1", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row = table.NewRow();
                row["Code"] = "";
                row["Name"] = "";
                table.Rows.InsertAt(row, 0);
                cbo_MaKH.aaDataSource = table;
                cbo_MaKH.aaSelectIndex = 0;
           
                Common.obj.Add_NewCommand("Select Code = MaHang, [Name] = TenHang from DM_HangHoa where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row1 = table1.NewRow();
                row1["Code"] = "";
                row1["Name"] = "";
                table1.Rows.InsertAt(row1, 0);
                cbo_HangHoa.aaDataSource = table1;
                cbo_HangHoa.aaSelectIndex = 0;
            
                Common.obj.Add_NewCommand("Select Code = MaNhom, [Name] = TenNhom from DM_NhomHang where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table2 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row2 = table2.NewRow();
                row2["Code"] = "";
                row2["Name"] = "";
                table2.Rows.InsertAt(row2, 0);
                cbo_NhomHang.aaDataSource = table2;
                cbo_NhomHang.aaSelectIndex = 0;
            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            GetData_BC();
        }
        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_CT_HangBan", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "TheoNhom");
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_NhomHang.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã nhóm";
                g_BC.Cols[1].Width = 100;
                g_BC.Cols[1].Visible = false;
                g_BC.Cols[2].Caption = "Tên nhóm";
                g_BC.Cols[2].Width = 300;
                g_BC.Cols[2].Visible = false;
                g_BC.Cols[3].Caption = "Mã hàng";
                g_BC.Cols[3].Width = 100;
                g_BC.Cols[3].Visible = true;
                g_BC.Cols[4].Caption = "Tên hàng";
                g_BC.Cols[4].Width = 300;
                g_BC.Cols[5].Caption = "Số lượng";
                g_BC.Cols[5].Width = 100;
                g_BC.Cols[5].Format = "##,##0";
                g_BC.Cols[5].Visible = true;
                g_BC.Cols[6].Caption = "Đơn giá";
                g_BC.Cols[6].Width = 100;
                g_BC.Cols[6].Format = "##,##0";
                g_BC.Cols[6].Visible = true;
                g_BC.Cols[7].Caption = "Thành tiền";
                g_BC.Cols[7].Format = "##,##0";
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                
                
                if (g_BC.Rows.Count > 1)
                {
                    int num2 = this.g_BC.Rows.Count - 1;
                    for (int i = 1; i <= num2; i++)
                    {
                        this.g_BC.Rows[i].Height = 25;
                    }
                    int index = g_BC.Cols["SL"].Index;
                    int index1 = g_BC.Cols["ThanhTien"].Index;
                    g_BC.Tree.Column = 4;
                    g_BC.Tree.Style = TreeStyleFlags.Simple;
                    g_BC.Subtotal(AggregateEnum.Clear);
                    g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index, "{0}");
                    g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index1, "{0}");
                    g_BC.Styles[CellStyleEnum.Subtotal0].BackColor = Color.Moccasin;
                    g_BC.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
                    g_BC.Styles[CellStyleEnum.Subtotal1].BackColor = Color.Moccasin;
                    g_BC.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Brown;
                    g_BC.Styles[CellStyleEnum.Subtotal1].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                    g_BC.Styles[CellStyleEnum.Subtotal2].BackColor = Color.Moccasin;
                    g_BC.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Brown;
                    g_BC.Styles[CellStyleEnum.Subtotal2].Font = new Font("Tahoma", 11f, FontStyle.Bold);

                    g_BC.Rows.Insert(g_BC.Rows.Count);
                    g_BC[g_BC.Rows.Count - 1, "SL"] = sys_Utility.sys_Utility.Sum_Col(dtBC, "SL");
                    g_BC[g_BC.Rows.Count - 1, "ThanhTien"] = sys_Utility.sys_Utility.Sum_Col(dtBC, "ThanhTien");
                    g_BC[g_BC.Rows.Count - 1, "TenHang"] = "TỔNG CỘNG:";
                    CellStyle newStyle = g_BC.Styles.Add("st");
                    newStyle.BackColor = Color.Moccasin;
                    newStyle.ForeColor = Color.Red;
                    newStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold);
                    int num3 = g_BC.Cols.Count - 1;
                    for (int j = g_BC.Cols.Fixed; j <= num3; j++)
                    {
                        g_BC.SetCellStyle(g_BC.Rows.Count - 1, j, newStyle);
                    }
                    g_BC.StartEditing(1, 1, '\0');
                    g_BC.Redraw = true;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }

        private void cbo_HangHoa_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_MaKH_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_NhomHang_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }
    }
}
