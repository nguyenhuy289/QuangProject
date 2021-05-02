namespace QuangProject
{
    partial class BH_DonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BH_DonDatHang));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.g_BC = new sg_control4.sg_Grid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.g_Item = new sg_control4.sg_Grid();
            this.cbo_HangHoa = new sg_control4.sg_ComboTwoCol();
            this.cbo_MaKH = new sg_control4.sg_ComboTwoCol();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.tn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaPhieu = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.groupControl4.Location = new System.Drawing.Point(598, 174);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(740, 543);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Danh sách đơn đặt hàng";
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
            this.g_BC.Size = new System.Drawing.Size(730, 510);
            this.g_BC.StyleInfo = resources.GetString("g_BC.StyleInfo");
            this.g_BC.TabIndex = 0;
            this.g_BC.Click += new System.EventHandler(this.g_BC_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.g_Item);
            this.groupControl2.Controls.Add(this.cbo_HangHoa);
            this.groupControl2.Controls.Add(this.cbo_MaKH);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.dtp_NgayLap);
            this.groupControl2.Controls.Add(this.btn_Save);
            this.groupControl2.Controls.Add(this.btn_Add);
            this.groupControl2.Controls.Add(this.btn_New);
            this.groupControl2.Controls.Add(this.tn_Edit);
            this.groupControl2.Controls.Add(this.btn_Del);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_MaPhieu);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(580, 705);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Đơn đặt hàng";
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
            this.g_Item.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:25;Name:\"STT\";Style:\"TextAlign:CenterBottom;\";}\t";
            this.g_Item.DragMode = C1.Win.C1FlexGrid.DragModeEnum.AutomaticCopy;
            this.g_Item.ExtendLastCol = true;
            this.g_Item.Font = new System.Drawing.Font("Arial", 12F);
            this.g_Item.Location = new System.Drawing.Point(5, 194);
            this.g_Item.Name = "g_Item";
            this.g_Item.Rows.DefaultSize = 23;
            this.g_Item.Size = new System.Drawing.Size(570, 451);
            this.g_Item.StyleInfo = resources.GetString("g_Item.StyleInfo");
            this.g_Item.TabIndex = 17;
            this.g_Item.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.g_Item_AfterEdit);
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
            this.cbo_HangHoa.Location = new System.Drawing.Point(5, 97);
            this.cbo_HangHoa.Name = "cbo_HangHoa";
            this.cbo_HangHoa.Size = new System.Drawing.Size(497, 24);
            this.cbo_HangHoa.TabIndex = 16;
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
            this.cbo_MaKH.Location = new System.Drawing.Point(5, 60);
            this.cbo_MaKH.Name = "cbo_MaKH";
            this.cbo_MaKH.Size = new System.Drawing.Size(561, 24);
            this.cbo_MaKH.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(380, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày lập";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(450, 29);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(116, 25);
            this.dtp_NgayLap.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(485, 656);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 38);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Add.Location = new System.Drawing.Point(508, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 38);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Location = new System.Drawing.Point(224, 656);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(81, 38);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "Thêm mới";
            this.btn_New.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // tn_Edit
            // 
            this.tn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_Edit.Appearance.Options.UseFont = true;
            this.tn_Edit.Location = new System.Drawing.Point(311, 656);
            this.tn_Edit.Name = "tn_Edit";
            this.tn_Edit.Size = new System.Drawing.Size(81, 38);
            this.tn_Edit.TabIndex = 6;
            this.tn_Edit.Text = "Sửa";
            this.tn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Appearance.Options.UseFont = true;
            this.btn_Del.Location = new System.Drawing.Point(398, 656);
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
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Hóa đơn";
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(105, 30);
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
            this.groupControl1.Controls.Add(this.cbo_HangHoa_BC);
            this.groupControl1.Controls.Add(this.cbo_KH_BC);
            this.groupControl1.Controls.Add(this.cbo_NH_BC);
            this.groupControl1.Controls.Add(this.dptDenNgay);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dptTuNgay);
            this.groupControl1.Location = new System.Drawing.Point(603, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(735, 156);
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
            // BH_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BH_DonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            this.Load += new System.EventHandler(this.BH_DonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton tn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_MaPhieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa_BC;
        private sg_control4.sg_ComboTwoCol cbo_KH_BC;
        private sg_control4.sg_ComboTwoCol cbo_NH_BC;
        private System.Windows.Forms.DateTimePicker dptDenNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dptTuNgay;
        private sg_control4.sg_Grid g_Item;
        private sg_control4.sg_ComboTwoCol cbo_HangHoa;
        private sg_control4.sg_ComboTwoCol cbo_MaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
    }
}