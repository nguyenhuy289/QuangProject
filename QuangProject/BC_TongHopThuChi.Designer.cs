namespace QuangProject
{
    partial class BC_TongHopThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC_TongHopThuChi));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_MaKH_BC = new sg_control4.sg_ComboTwoCol();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TongTien = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).BeginInit();
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
            this.groupControl4.Size = new System.Drawing.Size(1062, 543);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Tổng hợp Thu Chi";
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
            this.g_BC.Size = new System.Drawing.Size(1052, 510);
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
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_TongTien);
            this.groupControl1.Controls.Add(this.cbo_MaKH_BC);
            this.groupControl1.Controls.Add(this.dtp_DenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dtp_TuNgay);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1062, 156);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // cbo_MaKH_BC
            // 
            this.cbo_MaKH_BC.aaAcceptNextControl = true;
            this.cbo_MaKH_BC.aaAllowNull = true;
            this.cbo_MaKH_BC.aaBorderLine = false;
            this.cbo_MaKH_BC.aaCodeWidth = 100;
            this.cbo_MaKH_BC.aaErrorMessage = "Required input";
            this.cbo_MaKH_BC.aaField3 = "";
            this.cbo_MaKH_BC.aaField4 = "";
            this.cbo_MaKH_BC.aaField5 = "";
            this.cbo_MaKH_BC.aaFilterSync = false;
            this.cbo_MaKH_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKH_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_MaKH_BC.aaInsertRowNull = false;
            this.cbo_MaKH_BC.aaLabel = "Khách hàng";
            this.cbo_MaKH_BC.aaLabelSize = 11;
            this.cbo_MaKH_BC.aaLabelWidth = 100;
            this.cbo_MaKH_BC.aaListColWidth = "100,100,100,100";
            this.cbo_MaKH_BC.aaMaxDropDownItems = 6;
            this.cbo_MaKH_BC.aaParaNameFilter = "";
            this.cbo_MaKH_BC.aaSelectIndex = -1;
            this.cbo_MaKH_BC.aaShowField3 = false;
            this.cbo_MaKH_BC.aaShowField4 = false;
            this.cbo_MaKH_BC.aaShowField5 = false;
            this.cbo_MaKH_BC.aaValueCode = "";
            this.cbo_MaKH_BC.aaValueName = "";
            this.cbo_MaKH_BC.aaVisibleAddNew = false;
            this.cbo_MaKH_BC.aaVisibleText = true;
            this.cbo_MaKH_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_MaKH_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKH_BC.Location = new System.Drawing.Point(18, 64);
            this.cbo_MaKH_BC.Name = "cbo_MaKH_BC";
            this.cbo_MaKH_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_MaKH_BC.TabIndex = 13;
            this.cbo_MaKH_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_MaKH_BC_aaItemSelected);
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(352, 33);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(116, 25);
            this.dtp_DenNgay.TabIndex = 12;
            this.dtp_DenNgay.ValueChanged += new System.EventHandler(this.dtp_DenNgay_ValueChanged);
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
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(121, 33);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(116, 25);
            this.dtp_TuNgay.TabIndex = 9;
            this.dtp_TuNgay.ValueChanged += new System.EventHandler(this.dtp_TuNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chênh lệch Thu Chi";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.EditValue = "0";
            this.txt_TongTien.Location = new System.Drawing.Point(177, 103);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.txt_TongTien.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_TongTien.Properties.Appearance.Options.UseFont = true;
            this.txt_TongTien.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_TongTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongTien.Properties.Mask.EditMask = "#,###,###,##0";
            this.txt_TongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_TongTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_TongTien.Size = new System.Drawing.Size(290, 36);
            this.txt_TongTien.TabIndex = 24;
            // 
            // BC_TongHopThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BC_TongHopThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Tổng hợp Thu Chi";
            this.Load += new System.EventHandler(this.BC_TongHopThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private sg_control4.sg_Grid g_BC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private sg_control4.sg_ComboTwoCol cbo_MaKH_BC;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_TongTien;
    }
}