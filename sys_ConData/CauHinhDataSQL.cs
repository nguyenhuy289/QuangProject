using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sys_ConData
{
    

    public partial class CauHinhDataSQL : Form
    {
        private static ArrayList __ENCList;
        [DebuggerNonUserCode]
        static CauHinhDataSQL()
        {
            __ENCList = new ArrayList();
        }


        public CauHinhDataSQL()
        {
            __ENCList.Add(new WeakReference(this));
            this.InitializeComponent();
        }

        private void CauHinhDataSQL_Load(object sender, EventArgs e)
        {
            this.chkSuDung.Checked = true;
            this.chkSuDung_CheckedChanged(null, null);
            this.txt_HostSQL.Focus();

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (this.KiemTraDuLieu() != "")
            {
                MessageBox.Show(this.KiemTraDuLieu());
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                string connectionString = "";
                if (this.chkSuDung.Checked)
                {
                    connectionString = Conversions.ToString(Operators.AddObject(Operators.AddObject(((("Data Source=" + this.txt_HostSQL.Text + ";Initial Catalog=") + this.txt_Database.Text + ";User ID= ") + this.txt_Username.Text + " ;Password= ") + this.txt_Password.Text + " ;Connect Timeout=150;Integrated Security=", Interaction.IIf(this.chkSecurity.Checked, "True", "False")), ""));
                }
                else if (!this.chkSuDung.Checked)
                {
                    string[] strArray = new string[] { "Data Source=", this.txt_HostSQL.Text, ";Initial Catalog=", this.txt_Database.Text, ";User ID= ", this.txt_Username.Text, " ;Password= ", this.txt_Password.Text, " ;Connect Timeout=150" };
                    connectionString = string.Concat(strArray);
                }
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    connection.Close();
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Kết nối thành công.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Lỗi:" + exception.Message, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ProjectData.ClearProjectError();
                }
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.KiemTraDuLieu() != "")
                {
                    MessageBox.Show(this.KiemTraDuLieu());
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    string str = "";
                    if (this.chkSuDung.Checked)
                    {
                        str = Conversions.ToString(Operators.AddObject(Operators.AddObject(((("Data Source=" + this.txt_HostSQL.Text + ";Initial Catalog=") + this.txt_Database.Text + ";User ID= ") + this.txt_Username.Text + " ;Password= ") + this.txt_Password.Text + " ;Connect Timeout=150;Integrated Security=", Interaction.IIf(this.chkSecurity.Checked, "True", "False")), ""));
                    }
                    else if (!this.chkSuDung.Checked)
                    {
                        string[] strArray = new string[] { "Data Source=", this.txt_HostSQL.Text, ";Initial Catalog=", this.txt_Database.Text, ";User ID= ", this.txt_Username.Text, " ;Password= ", this.txt_Password.Text, " ;Connect Timeout=150" };
                        str = string.Concat(strArray);
                    }
                    this.WriteSetting("constr", sys_Con.MaHoa03(str, "PhuongNamSoft", true));
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Đ\x00e3 thiết lập file cấu h\x00ecnh th\x00e0nh c\x00f4ng!", "PhuongNamSoft", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.Cursor = Cursors.Default;
                MessageBox.Show("Lỗi:" + exception.Message, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ProjectData.ClearProjectError();
            }
    
        }

        private void chkSuDung_CheckedChanged(object sender, EventArgs e)
        {
            this.chkSecurity.Enabled = this.chkSuDung.Checked;
        }
        private string getConfigFilePath()
        {
            string str2 = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "");
            string[] strArray = str2.Split(new char[] { '/' });
            return (str2.Replace(strArray[strArray.Length - 1], "") + "Setting.config");
        }

        private string KiemTraDuLieu()
        {
            string str2 = "";
            int num = 0;
            if (this.txt_HostSQL.Text == "")
            {
                str2 = "Chưa nhập Data Source.\r\n";
                num = 1;
            }
            if (this.txt_Database.Text == "")
            {
                str2 = "Chưa nhập Database Name.\r\n";
                num = 2;
            }
            if (this.txt_Username.Text == "")
            {
                str2 = "Chưa nhập User ID.\r\n";
                num = 3;
            }
            if (!Versioned.IsNumeric(this.txt_Timeout.Text))
            {
                str2 = "Timeout nhập vào phải là số.\r\n";
                num = 4;
            }
            switch (num)
            {
                case 1:
                    this.txt_HostSQL.Focus();
                    break;

                case 2:
                    this.txt_Database.Focus();
                    break;

                case 3:
                    this.txt_Username.Focus();
                    break;

                case 4:
                    this.txt_Timeout.Focus();
                    break;

                default:
                    break;
            }
            return str2;
        }

        private XmlDocument loadConfigDocument()
        {
            XmlDocument document = null;
            XmlDocument document2;
            try
            {
                document = new XmlDocument();
                document.Load(this.getConfigFilePath());
                document2 = document;
            }
            catch (FileNotFoundException exception1)
            {
                FileNotFoundException ex = exception1;
                ProjectData.SetProjectError(ex);
                FileNotFoundException innerException = ex;
                throw new Exception("No configuration file found.", innerException);
            }
            return document2;
        }
        private void WriteSetting(string key, string value)
        {
            XmlDocument document = this.loadConfigDocument();
            XmlNode objA = document.SelectSingleNode("//connectionStrings");
            if (ReferenceEquals(objA, null))
            {
                throw new InvalidOperationException("appSettings section not found in config file.");
            }
            try
            {
                XmlElement element = (XmlElement)objA.SelectSingleNode($"//add[@name='{key}']");
                if (!ReferenceEquals(element, null))
                {
                    string attribute = element.GetAttribute("connectionString");
                    element.SetAttribute("connectionString", value);
                }
                else
                {
                    element = document.CreateElement("add");
                    element.SetAttribute("Name", key);
                    element.SetAttribute("connectionString", value);
                    objA.AppendChild(element);
                }
                document.Save(this.getConfigFilePath());
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                throw;
            }
        }
        
    }
}
