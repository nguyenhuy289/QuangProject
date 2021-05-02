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
    public partial class BC_CongNoPhaiTra : Form
    {
        DataTable dtBC;
        public BC_CongNoPhaiTra()
        {
            InitializeComponent();
        }

        private void BC_CongNoPhaiTra_Load(object sender, EventArgs e)
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1 and NCC = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_MaKH.aaDataSource = table1;
            cbo_MaKH.aaSelectIndex = 0;

            GetData_BC();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_CongNoKH", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@Type", SqlDbType.NVarChar, "PhaiTra");
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã NCC";
                g_BC.Cols[1].Width = 100;
                g_BC.Cols[1].Visible = true;
                g_BC.Cols[2].Caption = "Tên Nhà cung cấp";
                g_BC.Cols[2].Width = 300;
                g_BC.Cols[2].Visible = true;
                g_BC.Cols[3].Caption = "Ngày";
                g_BC.Cols[3].Width = 150;
                g_BC.Cols[3].Format = "dd/MM/yyyy";
                g_BC.Cols[4].Caption = "Mã Phiếu";
                g_BC.Cols[4].Width = 300;
                g_BC.Cols[5].Caption = "Công nợ";
                g_BC.Cols[5].Width = 120;
                g_BC.Cols[5].Format = "##,##0";
                g_BC.Cols[6].Caption = "Nội dung";
                g_BC.Cols[6].Width = 120;
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_BC.Rows[i].Height = 25;
                }
                g_BC.Tree.Column = 2;
                g_BC.Tree.Style = TreeStyleFlags.Simple;
                int index = g_BC.Cols["CongNo"].Index;
                if (g_BC.Rows.Count > 1)
                {
                    g_BC.Tree.Column = 2;
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

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_MaKH_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }
    }
}
