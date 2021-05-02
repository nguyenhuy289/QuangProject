namespace QuangProject
{
    partial class BC_NhapXuatTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC_NhapXuatTon));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_HangHoa = new sg_control4.sg_ComboTwoCol();
            this.cbo_MaKho = new sg_control4.sg_ComboTwoCol();
            this.cbo_MaNhom = new sg_control4.sg_ComboTwoCol();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
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
            this.groupControl4.Size = new System.Drawing.Size(1326, 543);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Báo cáo xuất nhập tồn";
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
            this.g_BC.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:50;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_BC.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_BC.ExtendLastCol = true;
            this.g_BC.Font = new System.Drawing.Font("Arial", 12F);
            this.g_BC.Location = new System.Drawing.Point(5, 28);
            this.g_BC.Name = "g_BC";
            this.g_BC.Rows.DefaultSize = 23;
            this.g_BC.Size = new System.Drawing.Size(1316, 510);
            this.g_BC.StyleInfo = resources.GetString("g_BC.StyleInfo");
            this.g_BC.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbo_HangHoa);
            this.groupControl1.Controls.Add(this.cbo_MaKho);
            this.groupControl1.Controls.Add(this.cbo_MaNhom);
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1326, 156);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // cbo_HangHoa
            // 
            this.cbo_HangHoa.aaAcceptNextControl = true;
            this.cbo_HangHoa.aaAllowNull = true;
            this.cbo_HangHoa.aaBorderLine = false;
            this.cbo_HangHoa.aaCodeWidth = 100;
            this.cbo_HangHoa.aaErrorMessage = "Required input";
            this.cbo_HangHoa.aaField3 = "";
            this.cbo_HangHoa.aaField4 = "";
            this.cbo_HangHoa.aaField5 = "";
            this.cbo_HangHoa.aaFilterSync = false;
            this.cbo_HangHoa.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HangHoa.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_HangHoa.aaInsertRowNull = false;
            this.cbo_HangHoa.aaLabel = "Hàng hóa";
            this.cbo_HangHoa.aaLabelSize = 11;
            this.cbo_HangHoa.aaLabelWidth = 100;
            this.cbo_HangHoa.aaListColWidth = "100,100,100,100";
            this.cbo_HangHoa.aaMaxDropDownItems = 6;
            this.cbo_HangHoa.aaParaNameFilter = "";
            this.cbo_HangHoa.aaSelectIndex = -1;
            this.cbo_HangHoa.aaShowField3 = false;
            this.cbo_HangHoa.aaShowField4 = false;
            this.cbo_HangHoa.aaShowField5 = false;
            this.cbo_HangHoa.aaValueCode = "";
            this.cbo_HangHoa.aaValueName = "";
            this.cbo_HangHoa.aaVisibleAddNew = false;
            this.cbo_HangHoa.aaVisibleText = true;
            this.cbo_HangHoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_HangHoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HangHoa.Location = new System.Drawing.Point(20, 123);
            this.cbo_HangHoa.Name = "cbo_HangHoa";
            this.cbo_HangHoa.Size = new System.Drawing.Size(450, 24);
            this.cbo_HangHoa.TabIndex = 15;
            this.cbo_HangHoa.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_HangHoa_aaItemSelected);
            // 
            // cbo_MaKho
            // 
            this.cbo_MaKho.aaAcceptNextControl = true;
            this.cbo_MaKho.aaAllowNull = true;
            this.cbo_MaKho.aaBorderLine = false;
            this.cbo_MaKho.aaCodeWidth = 100;
            this.cbo_MaKho.aaErrorMessage = "Required input";
            this.cbo_MaKho.aaField3 = "";
            this.cbo_MaKho.aaField4 = "";
            this.cbo_MaKho.aaField5 = "";
            this.cbo_MaKho.aaFilterSync = false;
            this.cbo_MaKho.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKho.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_MaKho.aaInsertRowNull = false;
            this.cbo_MaKho.aaLabel = "Kho hàng";
            this.cbo_MaKho.aaLabelSize = 11;
            this.cbo_MaKho.aaLabelWidth = 100;
            this.cbo_MaKho.aaListColWidth = "100,100,100,100";
            this.cbo_MaKho.aaMaxDropDownItems = 6;
            this.cbo_MaKho.aaParaNameFilter = "";
            this.cbo_MaKho.aaSelectIndex = -1;
            this.cbo_MaKho.aaShowField3 = false;
            this.cbo_MaKho.aaShowField4 = false;
            this.cbo_MaKho.aaShowField5 = false;
            this.cbo_MaKho.aaValueCode = "";
            this.cbo_MaKho.aaValueName = "";
            this.cbo_MaKho.aaVisibleAddNew = false;
            this.cbo_MaKho.aaVisibleText = true;
            this.cbo_MaKho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_MaKho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKho.Location = new System.Drawing.Point(20, 64);
            this.cbo_MaKho.Name = "cbo_MaKho";
            this.cbo_MaKho.Size = new System.Drawing.Size(450, 24);
            this.cbo_MaKho.TabIndex = 14;
            this.cbo_MaKho.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_MaKho_aaItemSelected);
            // 
            // cbo_MaNhom
            // 
            this.cbo_MaNhom.aaAcceptNextControl = true;
            this.cbo_MaNhom.aaAllowNull = true;
            this.cbo_MaNhom.aaBorderLine = false;
            this.cbo_MaNhom.aaCodeWidth = 100;
            this.cbo_MaNhom.aaErrorMessage = "Required input";
            this.cbo_MaNhom.aaField3 = "";
            this.cbo_MaNhom.aaField4 = "";
            this.cbo_MaNhom.aaField5 = "";
            this.cbo_MaNhom.aaFilterSync = false;
            this.cbo_MaNhom.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaNhom.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_MaNhom.aaInsertRowNull = false;
            this.cbo_MaNhom.aaLabel = "Nhóm hàng";
            this.cbo_MaNhom.aaLabelSize = 11;
            this.cbo_MaNhom.aaLabelWidth = 100;
            this.cbo_MaNhom.aaListColWidth = "100,100,100,100";
            this.cbo_MaNhom.aaMaxDropDownItems = 6;
            this.cbo_MaNhom.aaParaNameFilter = "";
            this.cbo_MaNhom.aaSelectIndex = -1;
            this.cbo_MaNhom.aaShowField3 = false;
            this.cbo_MaNhom.aaShowField4 = false;
            this.cbo_MaNhom.aaShowField5 = false;
            this.cbo_MaNhom.aaValueCode = "";
            this.cbo_MaNhom.aaValueName = "";
            this.cbo_MaNhom.aaVisibleAddNew = false;
            this.cbo_MaNhom.aaVisibleText = true;
            this.cbo_MaNhom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_MaNhom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaNhom.Location = new System.Drawing.Point(20, 94);
            this.cbo_MaNhom.Name = "cbo_MaNhom";
            this.cbo_MaNhom.Size = new System.Drawing.Size(450, 24);
            this.cbo_MaNhom.TabIndex = 13;
            this.cbo_MaNhom.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_MaNhom_aaItemSelected);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(352, 33);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(116, 25);
            this.dtpDenNgay.TabIndex = 12;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
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
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(121, 33);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(116, 25);
            this.dtpTuNgay.TabIndex = 9;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // BC_NhapXuatTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BC_NhapXuatTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Nhập xuất tồn";
            this.Load += new System.EventHandler(this.BC_NhapXuatTon_Load);
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
        private sg_control4.sg_ComboTwoCol cbo_MaKho;
        private sg_control4.sg_ComboTwoCol cbo_MaNhom;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa;
    }
}