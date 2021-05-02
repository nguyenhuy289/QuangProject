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
    public partial class Login : Form
    {
        bool flagDangNhap = false;
        public bool aafl_DangNhap()
        {
            return this.flagDangNhap;
        }
        public Login()
        {
            InitializeComponent(); 
            Common.obj = new sys_ConData.sys_ConData();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_TenDangNhap.Text == "quangdaika" & txt_MatKhau.Text == "masaigon") | (txt_TenDangNhap.Text == "9pos" & txt_MatKhau.Text == "nimda9"))
                {
                    flagDangNhap = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo");
                }
            }
            catch (System.Exception expr_81)
            {
                ProjectData.SetProjectError(expr_81);
                System.Exception ex = expr_81;
                throw ex;
            }
        }
        public bool aaKiemTraDangNhap()
        {
            return this.flagDangNhap;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
