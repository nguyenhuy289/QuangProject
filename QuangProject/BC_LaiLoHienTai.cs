using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuangProject
{
    public partial class BC_LaiLoHienTai : DevExpress.XtraEditors.XtraForm
    {
        public BC_LaiLoHienTai()
        {
            InitializeComponent();
        }

        private void BC_LaiLoHienTai_Load(object sender, EventArgs e)
        {
            GetData_LaiLo_HienTai();
        }
        private void GetData_LaiLo_HienTai()
        {
            Common.obj.Add_NewCommand("BC_LaiLoHienTai", sys_ConData.sys_ConData.cmdType.Store);
            DataTable table = Common.obj.ExecCommand_ReturnTable(Common.obj.Get_NewCommand());

            txt_CongNoPhaiTra.Text = table.Rows[0]["CongNoPhaiTra"].ToString();
            txt_CongNoPhaiThu.Text = table.Rows[0]["CongNoPhaiThu"].ToString();
            txt_GiaTriTonKho.Text = table.Rows[0]["GiaTriTonKho"].ToString();
            txt_LaiLoHienTai.Text = table.Rows[0]["ChenhLech"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetData_LaiLo_HienTai();
        }
    }
}