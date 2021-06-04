using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic.CompilerServices;
using sg_control4;
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
    public partial class Manager : Form
    {
        DataTable dt1;
        DataTable dt2;
        DataTable dtTK;
        public Manager()
        {
            InitializeComponent();
            Common.obj = new sys_ConData.sys_ConData();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();

            if (!frm.aafl_DangNhap())
            {
                this.Close();
            }
            else
            {
                //GetData_DS_HangTonKho();
                GetData_DS_HangCho_TheoKH();
                GetData_DS_HangCho();
                GetData_LaiLo_HienTai();
            }

            
        }
        private void GetData_LaiLo_HienTai()
        {
            Common.obj.Add_NewCommand("BC_LaiLoHienTai", sys_ConData.sys_ConData.cmdType.Store);
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            txt_CongNoPhaiTra.Text = table.Rows[0]["CongNoPhaiTra"].ToString();
            txt_CongNoPhaiThu.Text = table.Rows[0]["CongNoPhaiThu"].ToString();
            txt_GiaTriTonKho.Text = table.Rows[0]["GiaTriTonKho"].ToString();
            txt_LaiLoHienTai.Text = table.Rows[0]["ChenhLech"].ToString();

            if(Conversions.ToDouble(table.Rows[0]["ChenhLech"].ToString()) > 0)
            {
                txt_LaiLoHienTai.ForeColor = Color.Blue;
            }
        }

        private void GetData_DS_HangCho()
        {
            Common.obj.Add_NewCommand("BC_ChiTietHangCho", sys_ConData.sys_ConData.cmdType.Store);
            Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "");
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, "");
            dt1 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
            try
            {
                sg_Grid1.Redraw = false;
                sg_Grid1.DataSource = dt1;
                sg_Grid1.Cols[1].Caption = "Mã Hàng";
                sg_Grid1.Cols[1].Width = 70;
                sg_Grid1.Cols[1].Visible = true;
                sg_Grid1.Cols[2].Caption = "Tên Hàng";
                sg_Grid1.Cols[2].Width = 200;
                sg_Grid1.Cols[2].Visible = true;
                sg_Grid1.Cols[3].Caption = "SL";
                sg_Grid1.Rows[0].Height = 25;
                sg_Grid1.Rows[0].TextAlign = TextAlignEnum.CenterCenter;
                sg_Grid1.Styles.EmptyArea.BackColor = Color.White;
                int num2 = sg_Grid1.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    sg_Grid1.Rows[i].Height = 25;
                }
                if (sg_Grid1.Rows.Count > 1)
                {
                    sg_Grid1.Rows.Insert(sg_Grid1.Rows.Count);
                    sg_Grid1[sg_Grid1.Rows.Count - 1, "SL"] = sys_Utility.sys_Utility.Sum_Col(dt1, "SL");
                    sg_Grid1[sg_Grid1.Rows.Count - 1, "TenHang"] = "TỔNG CỘNG:";
                    CellStyle newStyle = sg_Grid1.Styles.Add("st");
                    newStyle.BackColor = Color.Moccasin;
                    newStyle.ForeColor = Color.Red;
                    newStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold);
                    int num3 = sg_Grid1.Cols.Count - 1;
                    for (int j = sg_Grid1.Cols.Fixed; j <= num3; j++)
                    {
                        sg_Grid1.SetCellStyle(sg_Grid1.Rows.Count - 1, j, newStyle);
                    }
                    sg_Grid1.StartEditing(1, 1, '\0');
                    sg_Grid1.Redraw = true;
                }
                else
                {
                    sg_Grid1.Redraw = true;
                }



            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }
        private void GetData_DS_HangCho_TheoKH()
        {
            try
            {
                Common.obj.Add_NewCommand("BC_ChiTietHangCho_TheoKH", sys_ConData.sys_ConData.cmdType.Store);
                Common.obj.Add_MyParametersCommand("@MaKH", SqlDbType.NVarChar, "");
                Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, "");
                dt2 = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());
                sg_Grid2.Redraw = false;
                sg_Grid2.DataSource = dt2;
                sg_Grid2.Cols[1].Caption = "Mã KH";
                sg_Grid2.Cols[1].Width = 70;
                sg_Grid2.Cols[1].Visible = false;
                sg_Grid2.Cols[2].Caption = "Tên KH";
                sg_Grid2.Cols[2].Width = 250;
                sg_Grid2.Cols[2].Visible = false;
                sg_Grid2.Cols[3].Caption = "Mã Hàng";
                sg_Grid2.Cols[3].Width = 70;
                sg_Grid2.Cols[4].Caption = "Tên Hàng";
                sg_Grid2.Cols[4].Width = 250;
                sg_Grid2.Cols[5].Caption = "SL";
                sg_Grid2.Rows[0].Height = 25;
                sg_Grid2.Rows[0].TextAlign = TextAlignEnum.CenterCenter;

                sg_Grid2.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.sg_Grid2.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.sg_Grid2.Rows[i].Height = 25;
                }
                if (sg_Grid2.Rows.Count > 1)
                {
                    sg_Grid2.Tree.Column = 4;
                    sg_Grid2.Tree.Style = TreeStyleFlags.Simple;
                    int index = sg_Grid2.Cols["SL"].Index;
                    sg_Grid2.Subtotal(AggregateEnum.Clear);
                    sg_Grid2.Subtotal(AggregateEnum.Sum, 1, 2, index, "{0}");
                    sg_Grid2.Styles[CellStyleEnum.Subtotal0].BackColor = Color.Moccasin;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal1].BackColor = Color.Moccasin;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Brown;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal1].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                    sg_Grid2.Styles[CellStyleEnum.Subtotal2].BackColor = Color.Moccasin;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Brown;
                    sg_Grid2.Styles[CellStyleEnum.Subtotal2].Font = new Font("Tahoma", 11f, FontStyle.Bold);
                    sg_Grid2.Redraw = true;
                }
                else
                {
                    sg_Grid2.Redraw = true;
                }

            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                throw exception;
            }

        }

        private void GetData_DS_HangTonKho()
        {
            Common.obj.Add_NewCommand("BC_TonKho", sys_ConData.sys_ConData.cmdType.Store);
            //Common.obj.Add_MyParametersCommand("@TuNgay", SqlDbType.NVarChar, dtpTuNgay.Value.ToString());
            Common.obj.Add_MyParametersCommand("@DenNgay", SqlDbType.NVarChar, DateTime.Today.ToString("yyyy-MM-dd"));
            Common.obj.Add_MyParametersCommand("@MaKho", SqlDbType.NVarChar, "");
            Common.obj.Add_MyParametersCommand("@MaNhom", SqlDbType.NVarChar, "");
            Common.obj.Add_MyParametersCommand("@MaHang", SqlDbType.NVarChar, "");
            dtTK = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            try
            {
                g_BC.DataSource = dtTK;
                g_BC.Cols[1].Caption = "Mã Nhóm";
                g_BC.Cols[1].Width = 100;
                g_BC.Cols[1].Visible = false;
                g_BC.Cols[2].Caption = "Tên Nhóm";
                g_BC.Cols[2].Width = 300;
                g_BC.Cols[2].Visible = false;
                g_BC.Cols[3].Caption = "Mã Hàng";
                g_BC.Cols[3].Width = 70;
                g_BC.Cols[4].Caption = "Tên Hàng";
                g_BC.Cols[4].Width = 200;
                g_BC.Cols[5].Caption = "Tồn kho";
                g_BC.Cols[5].AllowEditing = false;
                g_BC.Cols[6].Caption = "SLTKTT";
                g_BC.Cols[6].Visible = false;
                g_BC.Cols[5].Format = "##,##0";
                g_BC.Rows[0].Height = 25;
                g_BC.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

                g_BC.Styles.EmptyArea.BackColor = Color.White;
                int num2 = this.g_BC.Rows.Count - 1;
                for (int i = 1; i <= num2; i++)
                {
                    this.g_BC.Rows[i].Height = 25;
                    if(Conversions.ToInteger(g_BC[i, "SL"].ToString()) < Conversions.ToInteger(g_BC[i, "SLTKTT"].ToString()))
                    {
                        g_BC.Rows[i].StyleNew.BackColor = Color.OrangeRed;
                        g_BC.Rows[i].StyleNew.ForeColor = Color.White;
                    }
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
        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DM_DSKhachHang frm = new DM_DSKhachHang();
            frm.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DM_DSHangHoa frm = new DM_DSHangHoa();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BH_BanHang frm = new BH_BanHang();
            frm.Show();
            GetData_DS_HangCho();
            GetData_DS_HangCho_TheoKH();
            GetData_LaiLo_HienTai();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BH_DonDatHang frm = new BH_DonDatHang();
            frm.Show();
            GetData_DS_HangCho();
            GetData_DS_HangCho_TheoKH();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TK_NhapKho frm = new TK_NhapKho();
            frm.Show();
            GetData_DS_HangTonKho();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TK_XuatKho frm = new TK_XuatKho();
            frm.Show();
            GetData_DS_HangTonKho();
        }

        private void báoCáoChiTiếtHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_TonKho frm = new BC_TonKho();
            frm.Show();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TC_ThuTien frm = new TC_ThuTien();
            frm.Show();
            GetData_LaiLo_HienTai();
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TC_ChiTien frm = new TC_ChiTien();
            frm.Show();
            GetData_LaiLo_HienTai();
        }

        private void ngânQuỹToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_TongHopThuChi frm = new BC_TongHopThuChi();
            frm.Show();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_NhapXuatTon frm = new BC_NhapXuatTon();
            frm.Show();
        }

        private void đầuKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SYS_DauKy frm = new SYS_DauKy();
            frm.Show();
        }

        private void báoCáoCôngNợPhảiThuCủaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_CongNoPhaiThu frm = new BC_CongNoPhaiThu();
            frm.Show();
        }

        private void báoCáoCôngNợPhảiTrảChoNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_CongNoPhaiTra frm = new BC_CongNoPhaiTra();
            frm.Show();
        }

        private void báoCáoChiTiếtHàngBánTheoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_ChiTietHangTheoHoaDon frm = new BC_ChiTietHangTheoHoaDon();
            frm.Show();
        }

        private void báoCáoChiTiếtHàngBánTheoNhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_ChiTietHangTheoNhom frm = new BC_ChiTietHangTheoNhom();
            frm.Show();
        }

        private void báoCáoChiTiếtHàngBánTheoNhómHàngChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_ChiTietHangTheoChuongTrinh frm = new BC_ChiTietHangTheoChuongTrinh();
            frm.Show();
        }

        private void báoCáoKiểmKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_KiemKe frm = new BC_KiemKe();
            frm.Show();
        }

        private void kếtQuảKinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_KetQuaKinhDoanh frm = new BC_KetQuaKinhDoanh();
            frm.Show();
        }

        private void lãiLỗHiệnTịaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BC_LaiLoHienTai frm = new BC_LaiLoHienTai();
            frm.Show();
        }

        private void btn_CapNhatKho_Click(object sender, EventArgs e)
        {
            GetData_DS_HangTonKho();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
