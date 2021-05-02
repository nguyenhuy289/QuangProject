namespace QuangProject
{
    partial class BC_ChiTienHangCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC_ChiTienHangCho));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_HangHoa_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_KH_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_NH_BC = new sg_control4.sg_ComboTwoCol();
            this.dptDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dptTuNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.groupControl4.Controls.Add(this.g_BC);
            this.groupControl4.Location = new System.Drawing.Point(12, 174);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(844, 543);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Danh sách hàng chờ giao";
            // 
            // g_BC
            // 
            this.g_BC.aaColNotNull = "";
            this.g_BC.aaCopy = false;
            this.g_BC.aaFreezeBottom = false;
            this.g_BC.aaPaste = false;
            this.g_BC.AllowEditing = false;
            this.g_BC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_BC.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.g_BC.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:22;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_BC.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_BC.ExtendLastCol = true;
            this.g_BC.Font = new System.Drawing.Font("Arial", 12F);
            this.g_BC.Location = new System.Drawing.Point(5, 28);
            this.g_BC.Name = "g_BC";
            this.g_BC.Rows.DefaultSize = 23;
            this.g_BC.Size = new System.Drawing.Size(834, 510);
            this.g_BC.StyleInfo = resources.GetString("g_BC.StyleInfo");
            this.g_BC.TabIndex = 0;
            this.g_BC.Click += new System.EventHandler(this.g_BC_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbo_HangHoa_BC);
            this.groupControl1.Controls.Add(this.cbo_KH_BC);
            this.groupControl1.Controls.Add(this.cbo_NH_BC);
            this.groupControl1.Controls.Add(this.dptDenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dptTuNgay);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(844, 156);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // cbo_HangHoa_BC
            // 
            this.cbo_HangHoa_BC.aaAcceptNextControl = true;
            this.cbo_HangHoa_BC.aaAllowNull = true;
            this.cbo_HangHoa_BC.aaBorderLine = false;
            this.cbo_HangHoa_BC.aaCodeWidth = 100;
            this.cbo_HangHoa_BC.aaErrorMessage = "Required input";
            this.cbo_HangHoa_BC.aaField3 = "";
            this.cbo_HangHoa_BC.aaField4 = "";
            this.cbo_HangHoa_BC.aaField5 = "";
            this.cbo_HangHoa_BC.aaFilterSync = false;
            this.cbo_HangHoa_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HangHoa_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_HangHoa_BC.aaInsertRowNull = false;
            this.cbo_HangHoa_BC.aaLabel = "Hàng hóa";
            this.cbo_HangHoa_BC.aaLabelSize = 11;
            this.cbo_HangHoa_BC.aaLabelWidth = 100;
            this.cbo_HangHoa_BC.aaListColWidth = "100,100,100,100";
            this.cbo_HangHoa_BC.aaMaxDropDownItems = 6;
            this.cbo_HangHoa_BC.aaParaNameFilter = "";
            this.cbo_HangHoa_BC.aaSelectIndex = -1;
            this.cbo_HangHoa_BC.aaShowField3 = false;
            this.cbo_HangHoa_BC.aaShowField4 = false;
            this.cbo_HangHoa_BC.aaShowField5 = false;
            this.cbo_HangHoa_BC.aaValueCode = "";
            this.cbo_HangHoa_BC.aaValueName = "";
            this.cbo_HangHoa_BC.aaVisibleAddNew = false;
            this.cbo_HangHoa_BC.aaVisibleText = true;
            this.cbo_HangHoa_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_HangHoa_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HangHoa_BC.Location = new System.Drawing.Point(20, 123);
            this.cbo_HangHoa_BC.Name = "cbo_HangHoa_BC";
            this.cbo_HangHoa_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_HangHoa_BC.TabIndex = 15;
            this.cbo_HangHoa_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_KH_BC_aaItemSelected);
            // 
            // cbo_KH_BC
            // 
            this.cbo_KH_BC.aaAcceptNextControl = true;
            this.cbo_KH_BC.aaAllowNull = true;
            this.cbo_KH_BC.aaBorderLine = false;
            this.cbo_KH_BC.aaCodeWidth = 100;
            this.cbo_KH_BC.aaErrorMessage = "Required input";
            this.cbo_KH_BC.aaField3 = "";
            this.cbo_KH_BC.aaField4 = "";
            this.cbo_KH_BC.aaField5 = "";
            this.cbo_KH_BC.aaFilterSync = false;
            this.cbo_KH_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_KH_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_KH_BC.aaInsertRowNull = false;
            this.cbo_KH_BC.aaLabel = "Khách hàng";
            this.cbo_KH_BC.aaLabelSize = 11;
            this.cbo_KH_BC.aaLabelWidth = 100;
            this.cbo_KH_BC.aaListColWidth = "100,100,100,100";
            this.cbo_KH_BC.aaMaxDropDownItems = 6;
            this.cbo_KH_BC.aaParaNameFilter = "";
            this.cbo_KH_BC.aaSelectIndex = -1;
            this.cbo_KH_BC.aaShowField3 = false;
            this.cbo_KH_BC.aaShowField4 = false;
            this.cbo_KH_BC.aaShowField5 = false;
            this.cbo_KH_BC.aaValueCode = "";
            this.cbo_KH_BC.aaValueName = "";
            this.cbo_KH_BC.aaVisibleAddNew = false;
            this.cbo_KH_BC.aaVisibleText = true;
            this.cbo_KH_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_KH_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_KH_BC.Location = new System.Drawing.Point(20, 64);
            this.cbo_KH_BC.Name = "cbo_KH_BC";
            this.cbo_KH_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_KH_BC.TabIndex = 14;
            this.cbo_KH_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_KH_BC_aaItemSelected);
            // 
            // cbo_NH_BC
            // 
            this.cbo_NH_BC.aaAcceptNextControl = true;
            this.cbo_NH_BC.aaAllowNull = true;
            this.cbo_NH_BC.aaBorderLine = false;
            this.cbo_NH_BC.aaCodeWidth = 100;
            this.cbo_NH_BC.aaErrorMessage = "Required input";
            this.cbo_NH_BC.aaField3 = "";
            this.cbo_NH_BC.aaField4 = "";
            this.cbo_NH_BC.aaField5 = "";
            this.cbo_NH_BC.aaFilterSync = false;
            this.cbo_NH_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_NH_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_NH_BC.aaInsertRowNull = false;
            this.cbo_NH_BC.aaLabel = "Nhóm hàng";
            this.cbo_NH_BC.aaLabelSize = 11;
            this.cbo_NH_BC.aaLabelWidth = 100;
            this.cbo_NH_BC.aaListColWidth = "100,100,100,100";
            this.cbo_NH_BC.aaMaxDropDownItems = 6;
            this.cbo_NH_BC.aaParaNameFilter = "";
            this.cbo_NH_BC.aaSelectIndex = -1;
            this.cbo_NH_BC.aaShowField3 = false;
            this.cbo_NH_BC.aaShowField4 = false;
            this.cbo_NH_BC.aaShowField5 = false;
            this.cbo_NH_BC.aaValueCode = "";
            this.cbo_NH_BC.aaValueName = "";
            this.cbo_NH_BC.aaVisibleAddNew = false;
            this.cbo_NH_BC.aaVisibleText = true;
            this.cbo_NH_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_NH_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_NH_BC.Location = new System.Drawing.Point(20, 94);
            this.cbo_NH_BC.Name = "cbo_NH_BC";
            this.cbo_NH_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_NH_BC.TabIndex = 13;
            this.cbo_NH_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_KH_BC_aaItemSelected);
            // 
            // dptDenNgay
            // 
            this.dptDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dptDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptDenNgay.Location = new System.Drawing.Point(352, 33);
            this.dptDenNgay.Name = "dptDenNgay";
            this.dptDenNgay.Size = new System.Drawing.Size(116, 25);
            this.dptDenNgay.TabIndex = 12;
            this.dptDenNgay.ValueChanged += new System.EventHandler(this.dptDenNgay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(275, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Từ ngày";
            // 
            // dptTuNgay
            // 
            this.dptTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dptTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptTuNgay.Location = new System.Drawing.Point(121, 33);
            this.dptTuNgay.Name = "dptTuNgay";
            this.dptTuNgay.Size = new System.Drawing.Size(116, 25);
            this.dptTuNgay.TabIndex = 9;
            this.dptTuNgay.ValueChanged += new System.EventHandler(this.dptTuNgay_ValueChanged);
            // 
            // BC_ChiTienHangCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BC_ChiTienHangCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo chi tiết hàng chờ";
            this.Load += new System.EventHandler(this.BH_DonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private sg_control4.sg_Grid g_BC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa_BC;
        private sg_control4.sg_ComboTwoCol cbo_KH_BC;
        private sg_control4.sg_ComboTwoCol cbo_NH_BC;
        private System.Windows.Forms.DateTimePicker dptDenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
    }
}