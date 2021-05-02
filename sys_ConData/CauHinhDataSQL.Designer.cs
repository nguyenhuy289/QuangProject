namespace sys_ConData
{
    partial class CauHinhDataSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhDataSQL));
            this.txt_HostSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Timeout = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_HostSQL
            // 
            this.txt_HostSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txt_HostSQL.Location = new System.Drawing.Point(131, 28);
            this.txt_HostSQL.Name = "txt_HostSQL";
            this.txt_HostSQL.Size = new System.Drawing.Size(277, 22);
            this.txt_HostSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // txt_Database
            // 
            this.txt_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txt_Database.Location = new System.Drawing.Point(131, 56);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(277, 22);
            this.txt_Database.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txt_Username.Location = new System.Drawing.Point(131, 84);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(277, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txt_Password.Location = new System.Drawing.Point(131, 112);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(277, 22);
            this.txt_Password.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label5.Location = new System.Drawing.Point(274, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Timeout";
            // 
            // txt_Timeout
            // 
            this.txt_Timeout.Enabled = false;
            this.txt_Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txt_Timeout.Location = new System.Drawing.Point(349, 112);
            this.txt_Timeout.Name = "txt_Timeout";
            this.txt_Timeout.Size = new System.Drawing.Size(59, 22);
            this.txt_Timeout.TabIndex = 8;
            this.txt_Timeout.Text = "300";
            this.txt_Timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btn_Save.Location = new System.Drawing.Point(492, 102);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 50);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Lưu cấu hình";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btn_Check.Location = new System.Drawing.Point(492, 46);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(118, 50);
            this.btn_Check.TabIndex = 11;
            this.btn_Check.Text = "Kiểm tra";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.chkSuDung);
            this.groupBox1.Controls.Add(this.chkSecurity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_HostSQL);
            this.groupBox1.Controls.Add(this.txt_Database);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Timeout);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 157);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin SQL";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Enabled = false;
            this.chkSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chkSuDung.Location = new System.Drawing.Point(277, 159);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(80, 21);
            this.chkSuDung.TabIndex = 11;
            this.chkSuDung.Text = "Sử dụng";
            this.chkSuDung.UseVisualStyleBackColor = true;
            this.chkSuDung.CheckedChanged += new System.EventHandler(this.chkSuDung_CheckedChanged);
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Enabled = false;
            this.chkSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.chkSecurity.Location = new System.Drawing.Point(131, 159);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(79, 21);
            this.chkSecurity.TabIndex = 10;
            this.chkSecurity.Text = "Kiểm tra";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // CauHinhDataSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(657, 236);
            this.MinimumSize = new System.Drawing.Size(657, 236);
            this.Name = "CauHinhDataSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình SQL";
            this.Load += new System.EventHandler(this.CauHinhDataSQL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HostSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Timeout;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSuDung;
        private System.Windows.Forms.CheckBox chkSecurity;
    }
}