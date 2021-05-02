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

namespace QuangProject
{
    public partial class BC_ChiTienHangCho : Form
    {
        DataTable dt_Cbo_KH;
        DataTable dt_Cbo_KH_BC;
        DataTable dt_Cbo_HH;
        DataTable dt_Cbo_HH_BC;
        DataTable dt_Cbo_NH_BC;
        DataTable dtInfo;
        DataTable dtItem;
        DataTable dtBC;
        bool fl_new = true;

        public BC_ChiTienHangCho()
        {
            Common.obj = new sys_ConData.sys_ConData();
            InitializeComponent();
        }

        private void BH_DonDatHang_Load(object sender, EventArgs e)
        {
            GetData_CboKH();
            GetData_CboHH();
            Common.obj.Add_NewCommand("Select Code = MaNhom, Name = TenNhom from DM_NhomHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_NH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_NH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_NH_BC.Rows.InsertAt(row, 0);
            cbo_NH_BC.aaDataSource = dt_Cbo_NH_BC;
            GetData_BC();
        }
        private void GetData_BC()
        {
            Common.obj.Add_NewCommand("BC_ChiTietHangCho", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dptTuNgay.Value.ToString("yyyy-MM-dd"));
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dptDenNgay.Value.ToString("yyyy-MM-dd"));
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_NH_BC.aaValueCode.ToString());
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HangHoa_BC.aaValueCode.ToString());
            dtBC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            

            try
            {
                g_BC.DataSource = dtBC;
                g_BC.Cols[1].Caption = "Mã hàng";
                g_BC.Cols[1].Width = 100;
                g_BC.Cols[1].AllowEditing = false;
                g_BC.Cols[2].Caption = "Tên hàng";
                g_BC.Cols[2].Width = 350;
                g_BC.Cols[2].AllowEditing = false;
                g_BC.Cols[2].Visible = true;
                g_BC.Cols[3].Caption = "SL";
                g_BC.Cols[3].Width = 80;
                g_BC.Cols[3].Format = "#,##0";
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
        private void GetData_CboKH()
        {
            Common.obj.Add_NewCommand("Select Code = MaKH, Name = TenKH from DM_KhachHang where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_KH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_KH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_KH_BC.Rows.InsertAt(row, 0);
            cbo_KH_BC.aaDataSource = dt_Cbo_KH_BC;

        }
        private void GetData_CboHH()
        {
            Common.obj.Add_NewCommand("Select Code = MaHang, Name = TenHang from DM_HangHoa where SuDung = 1", sys_ConData.sys_ConData.cmdType.Query);
            dt_Cbo_HH_BC = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            DataRow row = dt_Cbo_HH_BC.NewRow();
            row["Code"] = "";
            row["Name"] = "";
            dt_Cbo_HH_BC.Rows.InsertAt(row, 0);
            cbo_HangHoa_BC.aaDataSource = dt_Cbo_HH_BC;
        }
        private void cbo_KH_BC_aaItemSelected(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dptDenNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void dptTuNgay_ValueChanged(object sender, EventArgs e)
        {
            GetData_BC();
        }

        private void g_BC_Click(object sender, EventArgs e)
        {
        }
        
    }
}
