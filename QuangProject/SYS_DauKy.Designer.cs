namespace QuangProject
{
    partial class SYS_DauKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SYS_DauKy));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Nam_HH_A = new System.Windows.Forms.NumericUpDown();
            this.cbo_Kho_A = new System.Windows.Forms.ComboBox();
            this.cbo_Kho = new sg_control4.sg_ComboTwoCol();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nam_HH = new System.Windows.Forms.NumericUpDown();
            this.g_HH = new sg_control4.sg_Grid();
            this.cbo_HH = new sg_control4.sg_ComboTwoCol();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SL = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_LoaiCN = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiCN_A = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nam_CN = new System.Windows.Forms.NumericUpDown();
            this.cbo_KH = new sg_control4.sg_ComboTwoCol();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoTien = new DevExpress.XtraEditors.TextEdit();
            this.g_CN = new sg_control4.sg_Grid();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_HH_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_CN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_CN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txt_Nam_HH_A);
            this.groupControl2.Controls.Add(this.cbo_Kho_A);
            this.groupControl2.Controls.Add(this.cbo_Kho);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txt_Nam_HH);
            this.groupControl2.Controls.Add(this.g_HH);
            this.groupControl2.Controls.Add(this.cbo_HH);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txt_SL);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(749, 705);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Tồn kho đầu kỳ";
            // 
            // txt_Nam_HH_A
            // 
            this.txt_Nam_HH_A.Location = new System.Drawing.Point(528, 657);
            this.txt_Nam_HH_A.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txt_Nam_HH_A.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.txt_Nam_HH_A.Name = "txt_Nam_HH_A";
            this.txt_Nam_HH_A.Size = new System.Drawing.Size(120, 25);
            this.txt_Nam_HH_A.TabIndex = 31;
            this.txt_Nam_HH_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Nam_HH_A.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.txt_Nam_HH_A.Visible = false;
            // 
            // cbo_Kho_A
            // 
            this.cbo_Kho_A.DisplayMember = "Code";
            this.cbo_Kho_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Kho_A.FormattingEnabled = true;
            this.cbo_Kho_A.Location = new System.Drawing.Point(391, 656);
            this.cbo_Kho_A.Name = "cbo_Kho_A";
            this.cbo_Kho_A.Size = new System.Drawing.Size(121, 26);
            this.cbo_Kho_A.TabIndex = 30;
            this.cbo_Kho_A.ValueMember = "Code";
            this.cbo_Kho_A.Visible = false;
            // 
            // cbo_Kho
            // 
            this.cbo_Kho.aaAcceptNextControl = true;
            this.cbo_Kho.aaAllowNull = true;
            this.cbo_Kho.aaBorderLine = false;
            this.cbo_Kho.aaCodeWidth = 100;
            this.cbo_Kho.aaErrorMessage = "Required input";
            this.cbo_Kho.aaField3 = "";
            this.cbo_Kho.aaField4 = "";
            this.cbo_Kho.aaField5 = "";
            this.cbo_Kho.aaFilterSync = false;
            this.cbo_Kho.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Kho.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_Kho.aaInsertRowNull = false;
            this.cbo_Kho.aaLabel = "Kho";
            this.cbo_Kho.aaLabelSize = 11;
            this.cbo_Kho.aaLabelWidth = 100;
            this.cbo_Kho.aaListColWidth = "100,100,100,100";
            this.cbo_Kho.aaMaxDropDownItems = 6;
            this.cbo_Kho.aaParaNameFilter = "";
            this.cbo_Kho.aaSelectIndex = -1;
            this.cbo_Kho.aaShowField3 = false;
            this.cbo_Kho.aaShowField4 = false;
            this.cbo_Kho.aaShowField5 = false;
            this.cbo_Kho.aaValueCode = "";
            this.cbo_Kho.aaValueName = "";
            this.cbo_Kho.aaVisibleAddNew = false;
            this.cbo_Kho.aaVisibleText = true;
            this.cbo_Kho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_Kho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Kho.Location = new System.Drawing.Point(5, 63);
            this.cbo_Kho.Name = "cbo_Kho";
            this.cbo_Kho.Size = new System.Drawing.Size(497, 24);
            this.cbo_Kho.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Năm";
            // 
            // txt_Nam_HH
            // 
            this.txt_Nam_HH.Location = new System.Drawing.Point(105, 32);
            this.txt_Nam_HH.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txt_Nam_HH.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.txt_Nam_HH.Name = "txt_Nam_HH";
            this.txt_Nam_HH.Size = new System.Drawing.Size(120, 25);
            this.txt_Nam_HH.TabIndex = 27;
            this.txt_Nam_HH.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // g_HH
            // 
            this.g_HH.aaColNotNull = "";
            this.g_HH.aaCopy = false;
            this.g_HH.aaFreezeBottom = false;
            this.g_HH.aaPaste = false;
            this.g_HH.AllowDelete = true;
            this.g_HH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_HH.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.g_HH.ColumnInfo = "9,1,0,0,0,115,Columns:0{Width:24;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_HH.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_HH.ExtendLastCol = true;
            this.g_HH.Font = new System.Drawing.Font("Arial", 12F);
            this.g_HH.Location = new System.Drawing.Point(5, 123);
            this.g_HH.Name = "g_HH";
            this.g_HH.Rows.DefaultSize = 23;
            this.g_HH.Size = new System.Drawing.Size(739, 518);
            this.g_HH.StyleInfo = resources.GetString("g_HH.StyleInfo");
            this.g_HH.TabIndex = 17;
            this.g_HH.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.g_HH_StartEdit);
            // 
            // cbo_HH
            // 
            this.cbo_HH.aaAcceptNextControl = true;
            this.cbo_HH.aaAllowNull = true;
            this.cbo_HH.aaBorderLine = false;
            this.cbo_HH.aaCodeWidth = 100;
            this.cbo_HH.aaErrorMessage = "Required input";
            this.cbo_HH.aaField3 = "";
            this.cbo_HH.aaField4 = "";
            this.cbo_HH.aaField5 = "";
            this.cbo_HH.aaFilterSync = false;
            this.cbo_HH.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HH.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_HH.aaInsertRowNull = false;
            this.cbo_HH.aaLabel = "Hàng hóa";
            this.cbo_HH.aaLabelSize = 11;
            this.cbo_HH.aaLabelWidth = 100;
            this.cbo_HH.aaListColWidth = "100,100,100,100";
            this.cbo_HH.aaMaxDropDownItems = 6;
            this.cbo_HH.aaParaNameFilter = "";
            this.cbo_HH.aaSelectIndex = -1;
            this.cbo_HH.aaShowField3 = false;
            this.cbo_HH.aaShowField4 = false;
            this.cbo_HH.aaShowField5 = false;
            this.cbo_HH.aaValueCode = "";
            this.cbo_HH.aaValueName = "";
            this.cbo_HH.aaVisibleAddNew = false;
            this.cbo_HH.aaVisibleText = true;
            this.cbo_HH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_HH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_HH.Location = new System.Drawing.Point(5, 93);
            this.cbo_HH.Name = "cbo_HH";
            this.cbo_HH.Size = new System.Drawing.Size(497, 24);
            this.cbo_HH.TabIndex = 16;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(654, 656);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(81, 38);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Text = "Lưu";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(508, 93);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 24);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(317, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            this.label2.Visible = false;
            // 
            // txt_SL
            // 
            this.txt_SL.EditValue = "0";
            this.txt_SL.Location = new System.Drawing.Point(413, 31);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Properties.Appearance.Options.UseFont = true;
            this.txt_SL.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_SL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_SL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SL.Properties.Mask.EditMask = "##,###,###,##0";
            this.txt_SL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_SL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_SL.Size = new System.Drawing.Size(89, 24);
            this.txt_SL.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbo_LoaiCN);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_Nam_CN);
            this.groupControl1.Controls.Add(this.cbo_KH);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_SoTien);
            this.groupControl1.Controls.Add(this.g_CN);
            this.groupControl1.Controls.Add(this.cbo_LoaiCN_A);
            this.groupControl1.Location = new System.Drawing.Point(767, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(571, 705);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Công nợ đầu kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(277, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Loại Công nợ";
            // 
            // cbo_LoaiCN
            // 
            this.cbo_LoaiCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiCN.FormattingEnabled = true;
            this.cbo_LoaiCN.Items.AddRange(new object[] {
            "PhaiThu",
            "PhaiTra"});
            this.cbo_LoaiCN.Location = new System.Drawing.Point(375, 61);
            this.cbo_LoaiCN.Name = "cbo_LoaiCN";
            this.cbo_LoaiCN.Size = new System.Drawing.Size(127, 26);
            this.cbo_LoaiCN.TabIndex = 32;
            // 
            // cbo_LoaiCN_A
            // 
            this.cbo_LoaiCN_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiCN_A.FormattingEnabled = true;
            this.cbo_LoaiCN_A.Items.AddRange(new object[] {
            "PhaiThu",
            "PhaiTra"});
            this.cbo_LoaiCN_A.Location = new System.Drawing.Point(47, 656);
            this.cbo_LoaiCN_A.Name = "cbo_LoaiCN_A";
            this.cbo_LoaiCN_A.Size = new System.Drawing.Size(121, 26);
            this.cbo_LoaiCN_A.TabIndex = 31;
            this.cbo_LoaiCN_A.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Năm";
            // 
            // txt_Nam_CN
            // 
            this.txt_Nam_CN.Location = new System.Drawing.Point(105, 32);
            this.txt_Nam_CN.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txt_Nam_CN.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.txt_Nam_CN.Name = "txt_Nam_CN";
            this.txt_Nam_CN.Size = new System.Drawing.Size(120, 25);
            this.txt_Nam_CN.TabIndex = 27;
            this.txt_Nam_CN.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cbo_KH
            // 
            this.cbo_KH.aaAcceptNextControl = true;
            this.cbo_KH.aaAllowNull = true;
            this.cbo_KH.aaBorderLine = false;
            this.cbo_KH.aaCodeWidth = 100;
            this.cbo_KH.aaErrorMessage = "Required input";
            this.cbo_KH.aaField3 = "";
            this.cbo_KH.aaField4 = "";
            this.cbo_KH.aaField5 = "";
            this.cbo_KH.aaFilterSync = false;
            this.cbo_KH.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_KH.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_KH.aaInsertRowNull = false;
            this.cbo_KH.aaLabel = "Khách hàng";
            this.cbo_KH.aaLabelSize = 11;
            this.cbo_KH.aaLabelWidth = 100;
            this.cbo_KH.aaListColWidth = "100,100,100,100";
            this.cbo_KH.aaMaxDropDownItems = 6;
            this.cbo_KH.aaParaNameFilter = "";
            this.cbo_KH.aaSelectIndex = -1;
            this.cbo_KH.aaShowField3 = false;
            this.cbo_KH.aaShowField4 = false;
            this.cbo_KH.aaShowField5 = false;
            this.cbo_KH.aaValueCode = "";
            this.cbo_KH.aaValueName = "";
            this.cbo_KH.aaVisibleAddNew = false;
            this.cbo_KH.aaVisibleText = true;
            this.cbo_KH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_KH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_KH.Location = new System.Drawing.Point(5, 93);
            this.cbo_KH.Name = "cbo_KH";
            this.cbo_KH.Size = new System.Drawing.Size(497, 24);
            this.cbo_KH.TabIndex = 16;
            this.cbo_KH.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_KH_aaItemSelected);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(476, 656);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 38);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(508, 93);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(58, 24);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(317, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số tiền";
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.EditValue = "0";
            this.txt_SoTien.Location = new System.Drawing.Point(375, 31);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.Properties.Appearance.Options.UseFont = true;
            this.txt_SoTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_SoTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_SoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SoTien.Properties.Mask.EditMask = "##,###,###,##0";
            this.txt_SoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_SoTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_SoTien.Size = new System.Drawing.Size(127, 24);
            this.txt_SoTien.TabIndex = 0;
            // 
            // g_CN
            // 
            this.g_CN.aaColNotNull = "";
            this.g_CN.aaCopy = false;
            this.g_CN.aaFreezeBottom = false;
            this.g_CN.aaPaste = false;
            this.g_CN.AllowDelete = true;
            this.g_CN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_CN.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.g_CN.ColumnInfo = "9,1,0,0,0,115,Columns:0{Width:24;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_CN.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_CN.ExtendLastCol = true;
            this.g_CN.Font = new System.Drawing.Font("Arial", 12F);
            this.g_CN.Location = new System.Drawing.Point(5, 123);
            this.g_CN.Name = "g_CN";
            this.g_CN.Rows.DefaultSize = 23;
            this.g_CN.Size = new System.Drawing.Size(561, 518);
            this.g_CN.StyleInfo = resources.GetString("g_CN.StyleInfo");
            this.g_CN.TabIndex = 17;
            this.g_CN.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.g_CN_StartEdit);
            // 
            // SYS_DauKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SYS_DauKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đầu kỳ";
            this.Load += new System.EventHandler(this.BH_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_HH_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nam_CN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_CN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_SL;
        private sg_control4.sg_Grid g_HH;
        private sg_control4.sg_ComboTwoCol cbo_HH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_Nam_HH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_Nam_CN;
        private sg_control4.sg_Grid g_CN;
        private sg_control4.sg_ComboTwoCol cbo_KH;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_SoTien;
        private sg_control4.sg_ComboTwoCol cbo_Kho;
        private System.Windows.Forms.ComboBox cbo_Kho_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_LoaiCN;
        private System.Windows.Forms.ComboBox cbo_LoaiCN_A;
        private System.Windows.Forms.NumericUpDown txt_Nam_HH_A;
    }
}