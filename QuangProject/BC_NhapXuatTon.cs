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
    
    public partial class BC_NhapXuatTon : Form
    {
        DataTable dtBC;
        public BC_NhapXuatTon()
        {
            InitializeComponent();
        }

        private void BC_NhapXuatTon_Load(object sender, EventArgs e)
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
            Common.obj.Add_NewCommand("BC_NhapXuatTonKho", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
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
                g_BC.Cols[4].Caption = "Tên Hàng";
                g_BC.Cols[4].Width = 300;
                g_BC.Cols[5].Caption = "SL đầu kỳ";
                g_BC.Cols[5].AllowEditing = false;
                g_BC.Cols[5].Width = 120;
                g_BC.Cols[5].Format = "##,##0";
                g_BC.Cols[6].Caption = "SL nhập";
                g_BC.Cols[6].AllowEditing = false;
                g_BC.Cols[6].Width = 120;
                g_BC.Cols[6].Format = "##,##0";
                g_BC.Cols[7].Caption = "SL xuất";
                g_BC.Cols[7].AllowEditing = false;
                g_BC.Cols[7].Width = 120;
                g_BC.Cols[7].Format = "##,##0";
                g_BC.Cols[8].Caption = "SL cuối kỳ";
                g_BC.Cols[8].AllowEditing = false;
                g_BC.Cols[8].Width = 120;
                g_BC.Cols[8].Format = "##,##0";
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
                int index = g_BC.Cols["SLDK"].Index;
                int index1 = g_BC.Cols["SLNTK"].Index;
                int index2 = g_BC.Cols["SLXTK"].Index;
                int index3 = g_BC.Cols["SLTC"].Index;
                g_BC.Subtotal(AggregateEnum.Clear);
                g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index, "{0}");
                g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index1, "{0}");
                g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index2, "{0}");
                g_BC.Subtotal(AggregateEnum.Sum, 1, 2, index3, "{0}");
                g_BC.Styles[CellStyleEnum.Subtotal0].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
                g_BC.Styles[CellStyleEnum.Subtotal1].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Brown;
                g_BC.Styles[CellStyleEnum.Subtotal1].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                g_BC.Styles[CellStyleEnum.Subtotal2].BackColor = Color.Moccasin;
                g_BC.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Brown;
                g_BC.Styles[CellStyleEnum.Subtotal2].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                g_BC.Redraw = true;
                if (g_BC.Rows.Count > 1)
                {
                    g_BC.Tree.Column = 4;
                    g_BC.Tree.Style = TreeStyleFlags.Simple;
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

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_MaNhom_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_HangHoa_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }
    }
}
