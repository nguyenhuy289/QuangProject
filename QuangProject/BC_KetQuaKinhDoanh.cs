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
    public partial class BC_KetQuaKinhDoanh : Form
    {
        DataTable dtBC;
        public BC_KetQuaKinhDoanh()
        {
            InitializeComponent();
        }

        private void BC_KetQuaKinhDoanh_Load(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_KetQuaKinhDoanh", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "STT";
                g_BC.Cols[1].Width = 60;
                g_BC.Cols[1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                g_BC.Cols[2].Caption = "Nội dung";
                g_BC.Cols[2].Width = 300;
                g_BC.Cols[3].Caption = "Công thức";
                g_BC.Cols[3].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                g_BC.Cols[3].Width = 120;
                g_BC.Cols[4].Caption = "Giá trị";
                g_BC.Cols[4].Format = "##,##0";
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_BC.Rows[i].Height = 25;
                    if (Conversions.ToDouble(g_BC.Rows[7]["TongTien"].ToString()) > 0)
                    {
                        g_BC.Rows[7].StyleNew.BackColor = Color.DodgerBlue;
                        g_BC.Rows[7].StyleNew.ForeColor = Color.White;
                    }
                    else
                    {
                        g_BC.Rows[7].StyleNew.BackColor = Color.Red;
                        g_BC.Rows[7].StyleNew.ForeColor = Color.White;
                    }
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
    }
}
