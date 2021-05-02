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

namespace QuangProject
{
    public partial class SYS_DauKy : Form
    {
        bool fl_new = true;
        DataTable dtInfo;
        DataTable dtItem;
        DataTable dtHH;
        DataTable dtCN;
        public SYS_DauKy()
        {
            InitializeComponent();
            Common.obj = new sys_ConData.sys_ConData();
        }
        private void BH_BanHang_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                Common.obj.Add_NewCommand("Select Code = MaKH, [Name] = TenKH from DM_KhachHang where SuDung = '1' and NV = '0'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row = table.NewRow();
                row["Code"] = "";
                row["Name"] = "";
                table.Rows.InsertAt(row, 0);
                cbo_KH.aaDataSource = table;
                cbo_KH.aaSelectIndex = 0;

                Common.obj.Add_NewCommand("Select Code = MaHang, [Name] = TenHang from DM_HangHoa where SuDung = '1'", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table2 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row2 = table2.NewRow();
                row2["Code"] = "";
                row2["Name"] = "";
                table2.Rows.InsertAt(row2, 0);
                cbo_HH.aaDataSource = table2;
                cbo_HH.aaSelectIndex = 0;

                Common.obj.Add_NewCommand("Select Code = MaKho, [Name] = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table3 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                DataRow row3 = table3.NewRow();
                row3["Code"] = "";
                row3["Name"] = "";
                table3.Rows.InsertAt(row3, 0);
                cbo_Kho.aaDataSource = table3;
                cbo_Kho.aaSelectIndex = 0;

                Common.obj.Add_NewCommand("Select Code = MaKho, [Name] = TenKho from DM_Kho", sys_ConData.sys_ConData.cmdType.Query);
                DataTable table4 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                cbo_Kho_A.DataSource = table4;


            }
            catch (Exception ex1)
            {
                Exception ex = ex1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            GetData_DK_HH();
            GetData_DK_CN();
        }

        private void GetData_DK_HH()
        {
            Common.obj.Add_NewCommand("BC_DK_HangHoa", sys_ConData.sys_ConData.cmdType.Store);
            dtHH = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_HH.DataSource = dtHH;
                g_HH.Cols[1].Caption = "Mã hàng";
                g_HH.Cols[1].Width = 90;
                g_HH.Cols[1].AllowEditing = false;
                g_HH.Cols[2].Caption = "Tên hàng";
                g_HH.Cols[2].Width = 250;
                g_HH.Cols[2].AllowEditing = false;
                g_HH.Cols[3].Caption = "Mã kho";
                g_HH.Cols[3].Width = 100;
                g_HH.Cols[4].Caption = "SL";
                g_HH.Cols[4].Width = 120;
                g_HH.Cols[4].Format = "##,##0";
                g_HH.Cols[5].Caption = "Năm";
                g_HH.Cols[5].Format = "####";
                g_HH.Rows[0].Height = 25;
                g_HH.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_HH.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_HH.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_HH.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }
        private void GetData_DK_CN()
        {
            Common.obj.Add_NewCommand("BC_DK_CongNo", sys_ConData.sys_ConData.cmdType.Store);
            dtCN = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_CN.DataSource = dtCN;
                g_CN.Cols[1].Caption = "Mã KH";
                g_CN.Cols[1].Width = 90;
                g_CN.Cols[1].AllowEditing = false;
                g_CN.Cols[2].Caption = "Tên KH";
                g_CN.Cols[2].Width = 200;
                g_CN.Cols[2].AllowEditing = false;
                g_CN.Cols[3].Caption = "Công nợ";
                g_CN.Cols[3].Width = 90;
                g_CN.Cols[3].Format = "##,##0";
                g_CN.Cols[4].Caption = "Năm";
                g_CN.Cols[4].Format = "####";
                g_CN.Cols[5].Caption = "Loại CN";
                g_CN.Rows[0].Height = 25;
                g_CN.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_CN.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_CN.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_CN.Rows[i].Height = 25;
                }


            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(cbo_Kho.aaValueCode.ToString() != "")
            {
                if(cbo_HH.aaValueCode.ToString() != "")
                {
                    if (txt_SL.Text != "0")
                    {
                        if(Conversions.ToInteger(txt_Nam_CN.Text) > 2019)
                        {
                            Common.obj.Add_NewCommand($"Select MaHang from sys_DK_HangHoa where MaHang = '{cbo_HH.aaValueCode.ToString()}' and MaKho = '{cbo_Kho.aaValueCode.ToString()}'", sys_ConData.sys_ConData.cmdType.Query);
                            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Hàng hóa đã có đầu kỳ ! Hãy kiểm tra kỹ lại !", "Thông báo");
                                return;
                            }
                            else
                            {
                                Common.obj.Add_NewCommand($"Insert into sys_DK_HangHoa (MaHang, MaKho, SL, Nam) values ('{cbo_HH.aaValueCode.ToString()}', '{cbo_Kho.aaValueCode.ToString()}', @SL, '{txt_Nam_HH.Text}')", sys_ConData.sys_ConData.cmdType.Query);
                                Common.obj.Add_MyParametersCommand("@SL", SqlDbType.Float, txt_SL.Text);
                                Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                            }
                        }
                        
                    }
                    GetData_DK_HH();
                }
            }
            
            //Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dptTuNgay.Value.ToString());
            //Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, dtpDenNgay.Value.ToString());
            //Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, cbo_NH_BC.aaValueCode.ToString());
            //Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, cbo_KH_BC.aaValueCode.ToString());
            //Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, cbo_HH_BC.aaValueCode.ToString());

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
                if (cbo_KH.aaValueCode.ToString() != "")
                {
                    if (txt_SoTien.Text != "0")
                    {
                        if (Conversions.ToInteger(txt_Nam_CN.Text) > 2019)
                        {
                            Common.obj.Add_NewCommand($"Insert into sys_DK_CongNo (MaKH, CongNo, Nam, LoaiCN) values ('{cbo_KH.aaValueCode.ToString()}', @CongNo, @Nam, '{cbo_LoaiCN.Text}')", sys_ConData.sys_ConData.cmdType.Query);
                            Common.obj.Add_MyParametersCommand("@CongNo", SqlDbType.Float, txt_SoTien.Text);
                            Common.obj.Add_MyParametersCommand("@Nam", SqlDbType.Float, txt_Nam_CN.Text);
                            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
                        }
                  
                    }
                    GetData_DK_CN();
                }
        }

        private void cbo_KH_aaItemSelected(object sender, EventArgs e)
        {

        }

        private void g_HH_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (this.g_HH.Cols[this.g_HH.Col].Name.ToLower() == "MaKho".ToLower())
            {
                g_HH.Editor = cbo_Kho_A;
            }
            else if (this.g_HH.Cols[this.g_HH.Col].Name.ToLower() == "Nam".ToLower())
            {
                g_HH.Editor = txt_Nam_HH_A;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DataTable table2 = dtHH.Copy();
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
            Common.obj.Add_NewCommand("Delete from sys_DK_HangHoa", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
            Common.obj.Add_NewCommand("Select MaHang, MaKho, SL, Nam from sys_DK_HangHoa", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.UpdateTable(Common.obj.Get_NewCommand(), table2);
            Common.obj.CommitTransaction();
            GetData_DK_HH();
        }

        private void g_CN_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (this.g_CN.Cols[this.g_CN.Col].Name.ToLower() == "LoaiCN".ToLower())
            {
                g_CN.Editor = cbo_LoaiCN_A;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable table2 = dtCN.Copy();
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
            Common.obj.Add_NewCommand("Delete from sys_DK_CongNo", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.ExecCommand_NoReturn(Common.obj.Get_NewCommand());
            Common.obj.Add_NewCommand("Select MaKH, CongNo, Nam, LoaiCN from sys_DK_CongNo", sys_ConData.sys_ConData.cmdType.Query);
            Common.obj.UpdateTable(Common.obj.Get_NewCommand(), table2);
            Common.obj.CommitTransaction();
            GetData_DK_CN();
        }
    }
}
