namespace QuangProject
{
    partial class DM_DSKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_DSKhachHang));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chk_KH_BC = new System.Windows.Forms.CheckBox();
            this.chk_NV_BC = new System.Windows.Forms.CheckBox();
            this.chk_NCC_BC = new System.Windows.Forms.CheckBox();
            this.chk_SuDungKH_BC = new System.Windows.Forms.CheckBox();
            this.g_KH = new sg_control4.sg_Grid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Zalo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_DonGia = new System.Windows.Forms.ComboBox();
            this.chk_KH = new System.Windows.Forms.CheckBox();
            this.chk_NV = new System.Windows.Forms.CheckBox();
            this.chk_NCC = new System.Windows.Forms.CheckBox();
            this.btn_Save_KH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New_KH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit_KH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del_KH = new DevExpress.XtraEditors.SimpleButton();
            this.chk_SuDung_KH = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Zalo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.chk_KH_BC);
            this.groupControl4.Controls.Add(this.chk_NV_BC);
            this.groupControl4.Controls.Add(this.chk_NCC_BC);
            this.groupControl4.Controls.Add(this.chk_SuDungKH_BC);
            this.groupControl4.Controls.Add(this.g_KH);
            this.groupControl4.Location = new System.Drawing.Point(12, 214);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(807, 445);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Danh sách Khách hàng";
            // 
            // chk_KH_BC
            // 
            this.chk_KH_BC.AutoSize = true;
            this.chk_KH_BC.Checked = true;
            this.chk_KH_BC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_KH_BC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_KH_BC.Location = new System.Drawing.Point(276, 38);
            this.chk_KH_BC.Name = "chk_KH_BC";
            this.chk_KH_BC.Size = new System.Drawing.Size(104, 22);
            this.chk_KH_BC.TabIndex = 14;
            this.chk_KH_BC.Text = "Khách hàng";
            this.chk_KH_BC.UseVisualStyleBackColor = true;
            this.chk_KH_BC.CheckedChanged += new System.EventHandler(this.chk_KH_BC_CheckedChanged);
            // 
            // chk_NV_BC
            // 
            this.chk_NV_BC.AutoSize = true;
            this.chk_NV_BC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_NV_BC.Location = new System.Drawing.Point(579, 38);
            this.chk_NV_BC.Name = "chk_NV_BC";
            this.chk_NV_BC.Size = new System.Drawing.Size(92, 22);
            this.chk_NV_BC.TabIndex = 13;
            this.chk_NV_BC.Text = "Nhân viên";
            this.chk_NV_BC.UseVisualStyleBackColor = true;
            this.chk_NV_BC.CheckedChanged += new System.EventHandler(this.chk_NV_BC_CheckedChanged);
            // 
            // chk_NCC_BC
            // 
            this.chk_NCC_BC.AutoSize = true;
            this.chk_NCC_BC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_NCC_BC.Location = new System.Drawing.Point(421, 38);
            this.chk_NCC_BC.Name = "chk_NCC_BC";
            this.chk_NCC_BC.Size = new System.Drawing.Size(117, 22);
            this.chk_NCC_BC.TabIndex = 12;
            this.chk_NCC_BC.Text = "Nhà cung cấp";
            this.chk_NCC_BC.UseVisualStyleBackColor = true;
            this.chk_NCC_BC.CheckedChanged += new System.EventHandler(this.chk_NCC_BC_CheckedChanged);
            // 
            // chk_SuDungKH_BC
            // 
            this.chk_SuDungKH_BC.AutoSize = true;
            this.chk_SuDungKH_BC.Checked = true;
            this.chk_SuDungKH_BC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SuDungKH_BC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_SuDungKH_BC.Location = new System.Drawing.Point(721, 38);
            this.chk_SuDungKH_BC.Name = "chk_SuDungKH_BC";
            this.chk_SuDungKH_BC.Size = new System.Drawing.Size(81, 22);
            this.chk_SuDungKH_BC.TabIndex = 5;
            this.chk_SuDungKH_BC.Text = "Sử dụng";
            this.chk_SuDungKH_BC.UseVisualStyleBackColor = true;
            this.chk_SuDungKH_BC.CheckedChanged += new System.EventHandler(this.chk_SuDungKH_BC_CheckedChanged);
            // 
            // g_KH
            // 
            this.g_KH.aaColNotNull = "";
            this.g_KH.aaCopy = false;
            this.g_KH.aaFreezeBottom = false;
            this.g_KH.aaPaste = false;
            this.g_KH.AllowEditing = false;
            this.g_KH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_KH.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.g_KH.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:50;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_KH.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_KH.ExtendLastCol = true;
            this.g_KH.Font = new System.Drawing.Font("Arial", 12F);
            this.g_KH.Location = new System.Drawing.Point(5, 66);
            this.g_KH.Name = "g_KH";
            this.g_KH.Rows.DefaultSize = 23;
            this.g_KH.Size = new System.Drawing.Size(797, 374);
            this.g_KH.StyleInfo = resources.GetString("g_KH.StyleInfo");
            this.g_KH.TabIndex = 0;
            this.g_KH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.g_KH_MouseDown);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.txt_Zalo);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txt_SDT);
            this.groupControl2.Controls.Add(this.lbl_DiaChi);
            this.groupControl2.Controls.Add(this.txt_DiaChi);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.cbo_DonGia);
            this.groupControl2.Controls.Add(this.chk_KH);
            this.groupControl2.Controls.Add(this.chk_NV);
            this.groupControl2.Controls.Add(this.chk_NCC);
            this.groupControl2.Controls.Add(this.btn_Save_KH);
            this.groupControl2.Controls.Add(this.btn_New_KH);
            this.groupControl2.Controls.Add(this.btn_Edit_KH);
            this.groupControl2.Controls.Add(this.btn_Del_KH);
            this.groupControl2.Controls.Add(this.chk_SuDung_KH);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txt_TenKH);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_MaKH);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(807, 196);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(448, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zalo";
            // 
            // txt_Zalo
            // 
            this.txt_Zalo.Enabled = false;
            this.txt_Zalo.Location = new System.Drawing.Point(584, 90);
            this.txt_Zalo.Name = "txt_Zalo";
            this.txt_Zalo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_Zalo.Properties.Appearance.Options.UseFont = true;
            this.txt_Zalo.Size = new System.Drawing.Size(209, 24);
            this.txt_Zalo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(448, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "SĐT";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Location = new System.Drawing.Point(584, 60);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(209, 24);
            this.txt_SDT.TabIndex = 16;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbl_DiaChi.Location = new System.Drawing.Point(448, 34);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 18);
            this.lbl_DiaChi.TabIndex = 15;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Location = new System.Drawing.Point(584, 31);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(209, 24);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giá bán";
            // 
            // cbo_DonGia
            // 
            this.cbo_DonGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DonGia.FormattingEnabled = true;
            this.cbo_DonGia.Items.AddRange(new object[] {
            "DonGia1",
            "DonGia2",
            "DonGia3",
            "DonGia4"});
            this.cbo_DonGia.Location = new System.Drawing.Point(156, 90);
            this.cbo_DonGia.Name = "cbo_DonGia";
            this.cbo_DonGia.Size = new System.Drawing.Size(262, 26);
            this.cbo_DonGia.TabIndex = 12;
            // 
            // chk_KH
            // 
            this.chk_KH.AutoSize = true;
            this.chk_KH.Checked = true;
            this.chk_KH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_KH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_KH.Location = new System.Drawing.Point(23, 124);
            this.chk_KH.Name = "chk_KH";
            this.chk_KH.Size = new System.Drawing.Size(104, 22);
            this.chk_KH.TabIndex = 11;
            this.chk_KH.Text = "Khách hàng";
            this.chk_KH.UseVisualStyleBackColor = true;
            this.chk_KH.CheckedChanged += new System.EventHandler(this.chk_KH_CheckedChanged);
            // 
            // chk_NV
            // 
            this.chk_NV.AutoSize = true;
            this.chk_NV.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_NV.Location = new System.Drawing.Point(326, 124);
            this.chk_NV.Name = "chk_NV";
            this.chk_NV.Size = new System.Drawing.Size(92, 22);
            this.chk_NV.TabIndex = 10;
            this.chk_NV.Text = "Nhân viên";
            this.chk_NV.UseVisualStyleBackColor = true;
            this.chk_NV.CheckedChanged += new System.EventHandler(this.chk_NV_CheckedChanged);
            // 
            // chk_NCC
            // 
            this.chk_NCC.AutoSize = true;
            this.chk_NCC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_NCC.Location = new System.Drawing.Point(168, 124);
            this.chk_NCC.Name = "chk_NCC";
            this.chk_NCC.Size = new System.Drawing.Size(117, 22);
            this.chk_NCC.TabIndex = 9;
            this.chk_NCC.Text = "Nhà cung cấp";
            this.chk_NCC.UseVisualStyleBackColor = true;
            this.chk_NCC.CheckedChanged += new System.EventHandler(this.chk_NCC_CheckedChanged);
            // 
            // btn_Save_KH
            // 
            this.btn_Save_KH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_KH.Appearance.Options.UseFont = true;
            this.btn_Save_KH.Location = new System.Drawing.Point(712, 142);
            this.btn_Save_KH.Name = "btn_Save_KH";
            this.btn_Save_KH.Size = new System.Drawing.Size(81, 38);
            this.btn_Save_KH.TabIndex = 8;
            this.btn_Save_KH.Text = "Lưu";
            this.btn_Save_KH.Click += new System.EventHandler(this.btn_Save_KH_Click);
            // 
            // btn_New_KH
            // 
            this.btn_New_KH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New_KH.Appearance.Options.UseFont = true;
            this.btn_New_KH.Location = new System.Drawing.Point(451, 142);
            this.btn_New_KH.Name = "btn_New_KH";
            this.btn_New_KH.Size = new System.Drawing.Size(81, 38);
            this.btn_New_KH.TabIndex = 7;
            this.btn_New_KH.Text = "Thêm mới";
            this.btn_New_KH.Click += new System.EventHandler(this.btn_New_KH_Click);
            // 
            // btn_Edit_KH
            // 
            this.btn_Edit_KH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_KH.Appearance.Options.UseFont = true;
            this.btn_Edit_KH.Location = new System.Drawing.Point(538, 142);
            this.btn_Edit_KH.Name = "btn_Edit_KH";
            this.btn_Edit_KH.Size = new System.Drawing.Size(81, 38);
            this.btn_Edit_KH.TabIndex = 6;
            this.btn_Edit_KH.Text = "Sửa";
            this.btn_Edit_KH.Click += new System.EventHandler(this.btn_Edit_KH_Click);
            // 
            // btn_Del_KH
            // 
            this.btn_Del_KH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del_KH.Appearance.Options.UseFont = true;
            this.btn_Del_KH.Location = new System.Drawing.Point(625, 142);
            this.btn_Del_KH.Name = "btn_Del_KH";
            this.btn_Del_KH.Size = new System.Drawing.Size(81, 38);
            this.btn_Del_KH.TabIndex = 5;
            this.btn_Del_KH.Text = "Xóa";
            this.btn_Del_KH.Click += new System.EventHandler(this.btn_Del_KH_Click);
            // 
            // chk_SuDung_KH
            // 
            this.chk_SuDung_KH.AutoSize = true;
            this.chk_SuDung_KH.Checked = true;
            this.chk_SuDung_KH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SuDung_KH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chk_SuDung_KH.Location = new System.Drawing.Point(23, 154);
            this.chk_SuDung_KH.Name = "chk_SuDung_KH";
            this.chk_SuDung_KH.Size = new System.Drawing.Size(81, 22);
            this.chk_SuDung_KH.TabIndex = 4;
            this.chk_SuDung_KH.Text = "Sử dụng";
            this.chk_SuDung_KH.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Enabled = false;
            this.txt_TenKH.Location = new System.Drawing.Point(156, 60);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Size = new System.Drawing.Size(262, 24);
            this.txt_TenKH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Location = new System.Drawing.Point(156, 31);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_MaKH.Properties.Appearance.Options.UseFont = true;
            this.txt_MaKH.Size = new System.Drawing.Size(262, 24);
            this.txt_MaKH.TabIndex = 0;
            // 
            // DM_DSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 671);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DM_DSKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Khách hàng - Nhà cung cấp";
            this.Load += new System.EventHandler(this.DM_DSKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Zalo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private sg_control4.sg_Grid g_KH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Save_KH;
        private DevExpress.XtraEditors.SimpleButton btn_New_KH;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_KH;
        private DevExpress.XtraEditors.SimpleButton btn_Del_KH;
        private System.Windows.Forms.CheckBox chk_SuDung_KH;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private System.Windows.Forms.CheckBox chk_SuDungKH_BC;
        private System.Windows.Forms.CheckBox chk_NV;
        private System.Windows.Forms.CheckBox chk_NCC;
        private System.Windows.Forms.CheckBox chk_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_DonGia;
        private System.Windows.Forms.CheckBox chk_KH_BC;
        private System.Windows.Forms.CheckBox chk_NV_BC;
        private System.Windows.Forms.CheckBox chk_NCC_BC;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_Zalo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
    }
}