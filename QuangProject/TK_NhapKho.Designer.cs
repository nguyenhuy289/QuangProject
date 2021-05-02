namespace QuangProject
{
    partial class TK_NhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TK_NhapKho));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.cbo_Kho = new sg_control4.sg_ComboTwoCol();
            this.txt_TongTien = new DevExpress.XtraEditors.TextEdit();
            this.cbo_LoaiNX = new sg_control4.sg_ComboTwoCol();
            this.txt_TongSL = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SL = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DonGia = new DevExpress.XtraEditors.TextEdit();
            this.g_Item = new sg_control4.sg_Grid();
            this.cbo_HangHoa = new sg_control4.sg_ComboTwoCol();
            this.cbo_KH = new sg_control4.sg_ComboTwoCol();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_Kho_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_HangHoa_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_KH_BC = new sg_control4.sg_ComboTwoCol();
            this.cbo_LoaiNX_BC = new sg_control4.sg_ComboTwoCol();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dptTuNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_Item)).BeginInit();
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
            this.groupControl4.Location = new System.Drawing.Point(746, 225);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(592, 492);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Danh sách phiếu nhập kho";
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
            this.g_BC.Size = new System.Drawing.Size(582, 459);
            this.g_BC.StyleInfo = resources.GetString("g_BC.StyleInfo");
            this.g_BC.TabIndex = 0;
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
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.dtp_NgayGiao);
            this.groupControl2.Controls.Add(this.cbo_Kho);
            this.groupControl2.Controls.Add(this.txt_TongTien);
            this.groupControl2.Controls.Add(this.cbo_LoaiNX);
            this.groupControl2.Controls.Add(this.txt_TongSL);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.txt_SL);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txt_DonGia);
            this.groupControl2.Controls.Add(this.g_Item);
            this.groupControl2.Controls.Add(this.cbo_HangHoa);
            this.groupControl2.Controls.Add(this.cbo_KH);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.dtp_NgayLap);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.btn_Add);
            this.groupControl2.Controls.Add(this.simpleButton6);
            this.groupControl2.Controls.Add(this.simpleButton7);
            this.groupControl2.Controls.Add(this.simpleButton8);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_MaPhieu);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(728, 705);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Nhập kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label9.Location = new System.Drawing.Point(520, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ngày giao";
            // 
            // dtp_NgayGiao
            // 
            this.dtp_NgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGiao.Location = new System.Drawing.Point(598, 120);
            this.dtp_NgayGiao.Name = "dtp_NgayGiao";
            this.dtp_NgayGiao.Size = new System.Drawing.Size(116, 25);
            this.dtp_NgayGiao.TabIndex = 4;
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
            this.cbo_Kho.aaLabel = "Mã Kho";
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
            this.cbo_Kho.Location = new System.Drawing.Point(2, 121);
            this.cbo_Kho.Name = "cbo_Kho";
            this.cbo_Kho.Size = new System.Drawing.Size(497, 24);
            this.cbo_Kho.TabIndex = 3;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.EditValue = "0";
            this.txt_TongTien.Location = new System.Drawing.Point(459, 626);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_TongTien.Properties.Appearance.Options.UseFont = true;
            this.txt_TongTien.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_TongTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongTien.Properties.Mask.EditMask = "##,###,###,##0";
            this.txt_TongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_TongTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_TongTien.Properties.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(255, 24);
            this.txt_TongTien.TabIndex = 26;
            // 
            // cbo_LoaiNX
            // 
            this.cbo_LoaiNX.aaAcceptNextControl = true;
            this.cbo_LoaiNX.aaAllowNull = true;
            this.cbo_LoaiNX.aaBorderLine = false;
            this.cbo_LoaiNX.aaCodeWidth = 100;
            this.cbo_LoaiNX.aaErrorMessage = "Required input";
            this.cbo_LoaiNX.aaField3 = "";
            this.cbo_LoaiNX.aaField4 = "";
            this.cbo_LoaiNX.aaField5 = "";
            this.cbo_LoaiNX.aaFilterSync = false;
            this.cbo_LoaiNX.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiNX.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_LoaiNX.aaInsertRowNull = false;
            this.cbo_LoaiNX.aaLabel = "Loại phiếu";
            this.cbo_LoaiNX.aaLabelSize = 11;
            this.cbo_LoaiNX.aaLabelWidth = 100;
            this.cbo_LoaiNX.aaListColWidth = "100,100,100,100";
            this.cbo_LoaiNX.aaMaxDropDownItems = 6;
            this.cbo_LoaiNX.aaParaNameFilter = "";
            this.cbo_LoaiNX.aaSelectIndex = -1;
            this.cbo_LoaiNX.aaShowField3 = false;
            this.cbo_LoaiNX.aaShowField4 = false;
            this.cbo_LoaiNX.aaShowField5 = false;
            this.cbo_LoaiNX.aaValueCode = "";
            this.cbo_LoaiNX.aaValueName = "";
            this.cbo_LoaiNX.aaVisibleAddNew = false;
            this.cbo_LoaiNX.aaVisibleText = true;
            this.cbo_LoaiNX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_LoaiNX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiNX.Location = new System.Drawing.Point(2, 33);
            this.cbo_LoaiNX.Name = "cbo_LoaiNX";
            this.cbo_LoaiNX.Size = new System.Drawing.Size(712, 24);
            this.cbo_LoaiNX.TabIndex = 0;
            this.cbo_LoaiNX.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiNX_aaItemSelected);
            // 
            // txt_TongSL
            // 
            this.txt_TongSL.EditValue = "0";
            this.txt_TongSL.Location = new System.Drawing.Point(79, 626);
            this.txt_TongSL.Name = "txt_TongSL";
            this.txt_TongSL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSL.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_TongSL.Properties.Appearance.Options.UseFont = true;
            this.txt_TongSL.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TongSL.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TongSL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_TongSL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongSL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_TongSL.Properties.Mask.EditMask = "##,##0";
            this.txt_TongSL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_TongSL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_TongSL.Properties.ReadOnly = true;
            this.txt_TongSL.Size = new System.Drawing.Size(67, 24);
            this.txt_TongSL.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(364, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tổng SL";
            // 
            // txt_SL
            // 
            this.txt_SL.EditValue = "1";
            this.txt_SL.Location = new System.Drawing.Point(102, 181);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Properties.Appearance.Options.UseFont = true;
            this.txt_SL.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_SL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_SL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_SL.Properties.Mask.EditMask = "##,##0";
            this.txt_SL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_SL.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_SL.Size = new System.Drawing.Size(67, 24);
            this.txt_SL.TabIndex = 6;
            this.txt_SL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SL_KeyDown);
            this.txt_SL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SL_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(305, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.EditValue = "0";
            this.txt_DonGia.Location = new System.Drawing.Point(380, 181);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Properties.Appearance.Options.UseFont = true;
            this.txt_DonGia.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_DonGia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_DonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_DonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_DonGia.Properties.Mask.EditMask = "##,##0";
            this.txt_DonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_DonGia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_DonGia.Size = new System.Drawing.Size(119, 24);
            this.txt_DonGia.TabIndex = 7;
            this.txt_DonGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DonGia_KeyDown);
            this.txt_DonGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SL_KeyUp);
            // 
            // g_Item
            // 
            this.g_Item.aaColNotNull = "";
            this.g_Item.aaCopy = false;
            this.g_Item.aaFreezeBottom = false;
            this.g_Item.aaPaste = false;
            this.g_Item.AllowDelete = true;
            this.g_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_Item.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.g_Item.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:50;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_Item.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_Item.ExtendLastCol = true;
            this.g_Item.Font = new System.Drawing.Font("Arial", 12F);
            this.g_Item.Location = new System.Drawing.Point(5, 228);
            this.g_Item.Name = "g_Item";
            this.g_Item.Rows.DefaultSize = 23;
            this.g_Item.Size = new System.Drawing.Size(718, 392);
            this.g_Item.StyleInfo = resources.GetString("g_Item.StyleInfo");
            this.g_Item.TabIndex = 17;
            this.g_Item.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.g_Item_AfterEdit);
            this.g_Item.AfterDeleteRow += new C1.Win.C1FlexGrid.RowColEventHandler(this.g_Item_AfterEdit);
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
            this.cbo_HangHoa.Location = new System.Drawing.Point(2, 151);
            this.cbo_HangHoa.Name = "cbo_HangHoa";
            this.cbo_HangHoa.Size = new System.Drawing.Size(497, 24);
            this.cbo_HangHoa.TabIndex = 5;
            this.cbo_HangHoa.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_HangHoa_aaItemSelected);
            this.cbo_HangHoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbo_HangHoa_KeyUp);
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
            this.cbo_KH.aaLabel = "Mã KH";
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
            this.cbo_KH.Location = new System.Drawing.Point(2, 91);
            this.cbo_KH.Name = "cbo_KH";
            this.cbo_KH.Size = new System.Drawing.Size(712, 24);
            this.cbo_KH.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(520, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày lập";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(598, 60);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(116, 25);
            this.dtp_NgayLap.TabIndex = 1;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(633, 656);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(81, 38);
            this.simpleButton5.TabIndex = 9;
            this.simpleButton5.Text = "Lưu";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Add.Location = new System.Drawing.Point(505, 151);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 54);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(372, 656);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(81, 38);
            this.simpleButton6.TabIndex = 12;
            this.simpleButton6.Text = "Thêm mới";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(459, 656);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(81, 38);
            this.simpleButton7.TabIndex = 11;
            this.simpleButton7.Text = "Sửa";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(546, 656);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(81, 38);
            this.simpleButton8.TabIndex = 10;
            this.simpleButton8.Text = "Xóa";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(6, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Phiếu";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(102, 61);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_MaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txt_MaPhieu.Properties.ReadOnly = true;
            this.txt_MaPhieu.Size = new System.Drawing.Size(267, 24);
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
            this.groupControl1.Controls.Add(this.cbo_Kho_BC);
            this.groupControl1.Controls.Add(this.cbo_HangHoa_BC);
            this.groupControl1.Controls.Add(this.cbo_KH_BC);
            this.groupControl1.Controls.Add(this.cbo_LoaiNX_BC);
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dptTuNgay);
            this.groupControl1.Location = new System.Drawing.Point(746, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(592, 202);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // cbo_Kho_BC
            // 
            this.cbo_Kho_BC.aaAcceptNextControl = true;
            this.cbo_Kho_BC.aaAllowNull = true;
            this.cbo_Kho_BC.aaBorderLine = false;
            this.cbo_Kho_BC.aaCodeWidth = 100;
            this.cbo_Kho_BC.aaErrorMessage = "Required input";
            this.cbo_Kho_BC.aaField3 = "";
            this.cbo_Kho_BC.aaField4 = "";
            this.cbo_Kho_BC.aaField5 = "";
            this.cbo_Kho_BC.aaFilterSync = false;
            this.cbo_Kho_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Kho_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_Kho_BC.aaInsertRowNull = false;
            this.cbo_Kho_BC.aaLabel = "Mã Kho";
            this.cbo_Kho_BC.aaLabelSize = 11;
            this.cbo_Kho_BC.aaLabelWidth = 100;
            this.cbo_Kho_BC.aaListColWidth = "100,100,100,100";
            this.cbo_Kho_BC.aaMaxDropDownItems = 6;
            this.cbo_Kho_BC.aaParaNameFilter = "";
            this.cbo_Kho_BC.aaSelectIndex = -1;
            this.cbo_Kho_BC.aaShowField3 = false;
            this.cbo_Kho_BC.aaShowField4 = false;
            this.cbo_Kho_BC.aaShowField5 = false;
            this.cbo_Kho_BC.aaValueCode = "";
            this.cbo_Kho_BC.aaValueName = "";
            this.cbo_Kho_BC.aaVisibleAddNew = false;
            this.cbo_Kho_BC.aaVisibleText = true;
            this.cbo_Kho_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_Kho_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Kho_BC.Location = new System.Drawing.Point(20, 121);
            this.cbo_Kho_BC.Name = "cbo_Kho_BC";
            this.cbo_Kho_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_Kho_BC.TabIndex = 28;
            this.cbo_Kho_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiNX_BC_aaItemSelected);
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
            this.cbo_HangHoa_BC.Location = new System.Drawing.Point(20, 151);
            this.cbo_HangHoa_BC.Name = "cbo_HangHoa_BC";
            this.cbo_HangHoa_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_HangHoa_BC.TabIndex = 15;
            this.cbo_HangHoa_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiNX_BC_aaItemSelected);
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
            this.cbo_KH_BC.Location = new System.Drawing.Point(20, 93);
            this.cbo_KH_BC.Name = "cbo_KH_BC";
            this.cbo_KH_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_KH_BC.TabIndex = 14;
            this.cbo_KH_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiNX_BC_aaItemSelected);
            // 
            // cbo_LoaiNX_BC
            // 
            this.cbo_LoaiNX_BC.aaAcceptNextControl = true;
            this.cbo_LoaiNX_BC.aaAllowNull = true;
            this.cbo_LoaiNX_BC.aaBorderLine = false;
            this.cbo_LoaiNX_BC.aaCodeWidth = 100;
            this.cbo_LoaiNX_BC.aaErrorMessage = "Required input";
            this.cbo_LoaiNX_BC.aaField3 = "";
            this.cbo_LoaiNX_BC.aaField4 = "";
            this.cbo_LoaiNX_BC.aaField5 = "";
            this.cbo_LoaiNX_BC.aaFilterSync = false;
            this.cbo_LoaiNX_BC.aaFontText = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiNX_BC.aaForeColorLabel = System.Drawing.Color.Black;
            this.cbo_LoaiNX_BC.aaInsertRowNull = false;
            this.cbo_LoaiNX_BC.aaLabel = "Loại phiếu";
            this.cbo_LoaiNX_BC.aaLabelSize = 11;
            this.cbo_LoaiNX_BC.aaLabelWidth = 100;
            this.cbo_LoaiNX_BC.aaListColWidth = "100,100,100,100";
            this.cbo_LoaiNX_BC.aaMaxDropDownItems = 6;
            this.cbo_LoaiNX_BC.aaParaNameFilter = "";
            this.cbo_LoaiNX_BC.aaSelectIndex = -1;
            this.cbo_LoaiNX_BC.aaShowField3 = false;
            this.cbo_LoaiNX_BC.aaShowField4 = false;
            this.cbo_LoaiNX_BC.aaShowField5 = false;
            this.cbo_LoaiNX_BC.aaValueCode = "";
            this.cbo_LoaiNX_BC.aaValueName = "";
            this.cbo_LoaiNX_BC.aaVisibleAddNew = false;
            this.cbo_LoaiNX_BC.aaVisibleText = true;
            this.cbo_LoaiNX_BC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbo_LoaiNX_BC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiNX_BC.Location = new System.Drawing.Point(20, 64);
            this.cbo_LoaiNX_BC.Name = "cbo_LoaiNX_BC";
            this.cbo_LoaiNX_BC.Size = new System.Drawing.Size(450, 24);
            this.cbo_LoaiNX_BC.TabIndex = 13;
            this.cbo_LoaiNX_BC.aaItemSelected += new sg_control4.sg_ComboTwoCol.aaItemSelectedHandler(this.cbo_LoaiNX_BC_aaItemSelected);
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
            // TK_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TK_NhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.TK_NhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_Item)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_MaPhieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa_BC;
        private sg_control4.sg_ComboTwoCol cbo_KH_BC;
        private sg_control4.sg_ComboTwoCol cbo_LoaiNX_BC;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
        private sg_control4.sg_Grid g_Item;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa;
        private sg_control4.sg_ComboTwoCol cbo_KH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private sg_control4.sg_ComboTwoCol cbo_LoaiNX;
        private DevExpress.XtraEditors.TextEdit txt_TongSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_SL;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_DonGia;
        private DevExpress.XtraEditors.TextEdit txt_TongTien;
        private sg_control4.sg_ComboTwoCol cbo_Kho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiao;
        private sg_control4.sg_ComboTwoCol cbo_Kho_BC;
    }
}