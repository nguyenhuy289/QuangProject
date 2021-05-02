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
    public partial class BC_TongHopThuChi : Form
    {
        DataTable dtBC;
        public BC_TongHopThuChi()
        {
            InitializeComponent();
            GetData_BC();
        }

        private void BC_TongHopThuChi_Load(object sender, EventArgs e)
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            DataTable table1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row1 = table1.NewRow();
            row1["Code"] = "";
            row1["Name"] = "";
            table1.Rows.InsertAt(row1, 0);
            cbo_MaKH_BC.aaDataSource = table1;
            cbo_MaKH_BC.aaSelectIndex = 0;
        }
        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_TongHopThuChi", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtp_TuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtp_DenNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_MaKH_BC.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Ngày";
                g_BC.Cols[1].Width = 120;
                g_BC.Cols[1].Format = "dd/MM/yyyy";
                g_BC.Cols[2].Caption = "Mã phiếu";
                g_BC.Cols[2].Width = 210;
                g_BC.Cols[2].AllowEditing = false;
                g_BC.Cols[3].Caption = "Loại TC";
                g_BC.Cols[3].Width = 80;
                g_BC.Cols[3].AllowEditing = true;
                g_BC.Cols[4].Caption = "Mã KH";
                g_BC.Cols[4].Format = "##,##0";
                g_BC.Cols[4].Width = 70;
                g_BC.Cols[5].Caption = "Tên KH";
                g_BC.Cols[5].Width = 170;
                g_BC.Cols[6].Caption = "Thu tiền";
                g_BC.Cols[6].Format = "##,##0";
                g_BC.Cols[6].Width = 150;
                g_BC.Cols[7].Caption = "Chi tiền";
                g_BC.Cols[7].Format = "##,##0";
                g_BC.Cols[7].Width = 150;
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    g_BC.Rows[i].Height = 25;
                }
                if (g_BC.Rows.Count > 1)
                {
                    g_BC.Rows.Insert(g_BC.Rows.Count);
                    double tthu = 0;
                    double tchi = 0;
                    g_BC[g_BC.Rows.Count - 1, "ThuTien"] = tthu = sys_Utility.sys_Utility.Sum_Col(dtBC, "ThuTien");
                    g_BC[g_BC.Rows.Count - 1, "ChiTien"] = tchi =  sys_Utility.sys_Utility.Sum_Col(dtBC, "ChiTien");
                    g_BC[g_BC.Rows.Count - 1, "TenKH"] = "TỔNG CỘNG:";
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
                    txt_TongTien.Text = Conversions.ToString(tthu - tchi);
                }
                else
                {
                    txt_TongTien.Text = "0";
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }

        private void dtp_DenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dtp_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void cbo_MaKH_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }
    }
}
