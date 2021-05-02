namespace QuangProject
{
    partial class TC_ThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TC_ThuTien));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_CongNo = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_LyDo = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_LoaiTC = new sg_control4.sg_ComboTwoCol();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TongTien = new DevExpress.XtraEditors.TextEdit();
            this.cbo_MaKH = new sg_control4.sg_ComboTwoCol();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_MaKH_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_LoaiTC_BC = new sg_control4.sg_ComboTwoCol();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CongNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieu.Properties)).BeginInit();
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
            this.groupControl4.Location = new System.Drawing.Point(448, 174);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(890, 543);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Danh sách phiếu thu tiền";
            // 
            // g_BC
            // 
            this.g_BC.aaColNotNull = "";
            this.g_BC.aaCopy = false;
            this.g_BC.aaFreezeBottom = false;
            this.g_BC.aaPaste = false;
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
            this.g_BC.Size = new System.Drawing.Size(880, 510);
            this.g_BC.StyleInfo = resources.GetString("g_BC.StyleInfo");
            this.g_BC.TabIndex = 0;
            this.g_BC.Click += new System.EventHandler(this.g_BC_Click);
            this.g_BC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_BC_MouseClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txt_CongNo);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.txt_LyDo);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.cbo_LoaiTC);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txt_TongTien);
            this.groupControl2.Controls.Add(this.cbo_MaKH);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.dtp_NgayLap);
            this.groupControl2.Controls.Add(this.btn_Save);
            this.groupControl2.Controls.Add(this.btn_New);
            this.groupControl2.Controls.Add(this.btn_Edit);
            this.groupControl2.Controls.Add(this.btn_Del);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_MaPhieu);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(430, 705);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Thu tiền";
            // 
            // txt_CongNo
            // 
            this.txt_CongNo.EditValue = "0";
            this.txt_CongNo.Enabled = false;
            this.txt_CongNo.Location = new System.Drawing.Point(102, 156);
            this.txt_CongNo.Name = "txt_CongNo";
            this.txt_CongNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txt_CongNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CongNo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txt_CongNo.Properties.Appearance.Options.UseBackColor = true;
            this.txt_CongNo.Properties.Appearance.Options.UseFont = true;
            this.txt_CongNo.Properties.Appearance.Options.UseForeColor = true;
            this.txt_CongNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_CongNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_CongNo.Properties.Mask.EditMask = "###,###,###,##0";
            this.txt_CongNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_CongNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_CongNo.Size = new System.Drawing.Size(318, 24);
            this.txt_CongNo.TabIndex = 145;
            this.txt_CongNo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 143;
            this.label9.Text = "Công nợ";
            this.label9.Visible = false;
            // 
            // txt_LyDo
            // 
            this.txt_LyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LyDo.Location = new System.Drawing.Point(102, 193);
            this.txt_LyDo.Name = "txt_LyDo";
            this.txt_LyDo.Size = new System.Drawing.Size(318, 141);
            this.txt_LyDo.TabIndex = 141;
            this.txt_LyDo.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 142;
            this.label10.Text = "Lý do";
            // 
            // cbo_LoaiTC
            // 
            this.cbo_LoaiTC.aaAcceptNextControl = true;
            this.cbo_LoaiTC.aaAllowNull = true;
            this.cbo_LoaiTC.aaBorderLine = false;
            this.cbo_LoaiTC.aaCodeWidth = 100;
            this.cbo_LoaiTC.aaErrorMessage = "Required input";
            this.cbo_LoaiTC.aaField3 = "";
            this.cbo_LoaiTC.aaField4 = "";
            this.cbo_LoaiTC.aaField5 = "";
            this.cbo_LoaiTC.aaFilterSync = false;
            this.cbo_LoaiTC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiTC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_LoaiTC.aaInsertRowNull = false;
            this.cbo_LoaiTC.aaLabel = "Loại phiếu";
            this.cbo_LoaiTC.aaLabelSize = 11;
            this.cbo_LoaiTC.aaLabelWidth = 100;
            this.cbo_LoaiTC.aaListColWidth = "100,100,100,100";
            this.cbo_LoaiTC.aaMaxDropDownItems = 6;
            this.cbo_LoaiTC.aaParaNameFilter = "";
            this.cbo_LoaiTC.aaSelectIndex = -1;
            this.cbo_LoaiTC.aaShowField3 = false;
            this.cbo_LoaiTC.aaShowField4 = false;
            this.cbo_LoaiTC.aaShowField5 = false;
            this.cbo_LoaiTC.aaValueCode = "";
            this.cbo_LoaiTC.aaValueName = "";
            this.cbo_LoaiTC.aaVisibleAddNew = false;
            this.cbo_LoaiTC.aaVisibleText = true;
            this.cbo_LoaiTC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_LoaiTC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiTC.Location = new System.Drawing.Point(2, 33);
            this.cbo_LoaiTC.Name = "cbo_LoaiTC";
            this.cbo_LoaiTC.Size = new System.Drawing.Size(418, 24);
            this.cbo_LoaiTC.TabIndex = 25;
            this.cbo_LoaiTC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiTC_aaItemSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tiền thu";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.EditValue = "0";
            this.txt_TongTien.Location = new System.Drawing.Point(102, 340);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_TongTien.Size = new System.Drawing.Size(318, 24);
            this.txt_TongTien.TabIndex = 22;
            // 
            // cbo_MaKH
            // 
            this.cbo_MaKH.aaAcceptNextControl = true;
            this.cbo_MaKH.aaAllowNull = true;
            this.cbo_MaKH.aaBorderLine = false;
            this.cbo_MaKH.aaCodeWidth = 100;
            this.cbo_MaKH.aaErrorMessage = "Required input";
            this.cbo_MaKH.aaField3 = "";
            this.cbo_MaKH.aaField4 = "";
            this.cbo_MaKH.aaField5 = "";
            this.cbo_MaKH.aaFilterSync = false;
            this.cbo_MaKH.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKH.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_MaKH.aaInsertRowNull = false;
            this.cbo_MaKH.aaLabel = "Khách hàng";
            this.cbo_MaKH.aaLabelSize = 11;
            this.cbo_MaKH.aaLabelWidth = 100;
            this.cbo_MaKH.aaListColWidth = "100,100,100,100";
            this.cbo_MaKH.aaMaxDropDownItems = 6;
            this.cbo_MaKH.aaParaNameFilter = "";
            this.cbo_MaKH.aaSelectIndex = -1;
            this.cbo_MaKH.aaShowField3 = false;
            this.cbo_MaKH.aaShowField4 = false;
            this.cbo_MaKH.aaShowField5 = false;
            this.cbo_MaKH.aaValueCode = "";
            this.cbo_MaKH.aaValueName = "";
            this.cbo_MaKH.aaVisibleAddNew = false;
            this.cbo_MaKH.aaVisibleText = true;
            this.cbo_MaKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_MaKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKH.Location = new System.Drawing.Point(2, 125);
            this.cbo_MaKH.Name = "cbo_MaKH";
            this.cbo_MaKH.Size = new System.Drawing.Size(418, 24);
            this.cbo_MaKH.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(9, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày lập";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(102, 94);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(190, 25);
            this.dtp_NgayLap.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(344, 662);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 38);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Location = new System.Drawing.Point(83, 662);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(81, 38);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "Thêm mới";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Location = new System.Drawing.Point(170, 662);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(81, 38);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Appearance.Options.UseFont = true;
            this.btn_Del.Location = new System.Drawing.Point(257, 662);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(81, 38);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Hóa đơn";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(102, 63);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_MaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txt_MaPhieu.Properties.ReadOnly = true;
            this.txt_MaPhieu.Size = new System.Drawing.Size(190, 24);
            this.txt_MaPhieu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbo_MaKH_BC);
            this.groupControl1.Controls.Add(this.cbo_LoaiTC_BC);
            this.groupControl1.Controls.Add(this.dtp_DenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dtp_TuNgay);
            this.groupControl1.Location = new System.Drawing.Point(448, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(890, 156);
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
            this.cbo_MaKH_BC.Location = new System.Drawing.Point(18, 94);
            this.cbo_MaKH_BC.Name = "cbo_MaKH_BC";
            this.cbo_MaKH_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_MaKH_BC.TabIndex = 14;
            this.cbo_MaKH_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_MaKH_BC_aaItemSelected);
            // 
            // cbo_LoaiTC_BC
            // 
            this.cbo_LoaiTC_BC.aaAcceptNextControl = true;
            this.cbo_LoaiTC_BC.aaAllowNull = true;
            this.cbo_LoaiTC_BC.aaBorderLine = false;
            this.cbo_LoaiTC_BC.aaCodeWidth = 100;
            this.cbo_LoaiTC_BC.aaErrorMessage = "Required input";
            this.cbo_LoaiTC_BC.aaField3 = "";
            this.cbo_LoaiTC_BC.aaField4 = "";
            this.cbo_LoaiTC_BC.aaField5 = "";
            this.cbo_LoaiTC_BC.aaFilterSync = false;
            this.cbo_LoaiTC_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiTC_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_LoaiTC_BC.aaInsertRowNull = false;
            this.cbo_LoaiTC_BC.aaLabel = "Loại phiếu";
            this.cbo_LoaiTC_BC.aaLabelSize = 11;
            this.cbo_LoaiTC_BC.aaLabelWidth = 100;
            this.cbo_LoaiTC_BC.aaListColWidth = "100,100,100,100";
            this.cbo_LoaiTC_BC.aaMaxDropDownItems = 6;
            this.cbo_LoaiTC_BC.aaParaNameFilter = "";
            this.cbo_LoaiTC_BC.aaSelectIndex = -1;
            this.cbo_LoaiTC_BC.aaShowField3 = false;
            this.cbo_LoaiTC_BC.aaShowField4 = false;
            this.cbo_LoaiTC_BC.aaShowField5 = false;
            this.cbo_LoaiTC_BC.aaValueCode = "";
            this.cbo_LoaiTC_BC.aaValueName = "";
            this.cbo_LoaiTC_BC.aaVisibleAddNew = false;
            this.cbo_LoaiTC_BC.aaVisibleText = true;
            this.cbo_LoaiTC_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_LoaiTC_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiTC_BC.Location = new System.Drawing.Point(18, 64);
            this.cbo_LoaiTC_BC.Name = "cbo_LoaiTC_BC";
            this.cbo_LoaiTC_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_LoaiTC_BC.TabIndex = 13;
            this.cbo_LoaiTC_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiTC_BC_aaItemSelected);
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
            // TC_ThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TC_ThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu tiền";
            this.Load += new System.EventHandler(this.TC_ThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CongNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private sg_control4.sg_Grid g_BC;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_MaPhieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private sg_control4.sg_ComboTwoCol cbo_MaKH_BC;
        private sg_control4.sg_ComboTwoCol cbo_LoaiTC_BC;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private sg_control4.sg_ComboTwoCol cbo_MaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private sg_control4.sg_ComboTwoCol cbo_LoaiTC;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_TongTien;
        private DevExpress.XtraEditors.TextEdit txt_CongNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txt_LyDo;
        private System.Windows.Forms.Label label10;
    }
}