namespace Presentation.User_controls
{
    partial class ucThemCongViec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThemCongViec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenCongViec = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvDSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cbbDuAn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(28, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(83, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(79, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dự án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(48, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phân công";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(137, 67);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTenCongViec.Properties.Appearance.Options.UseFont = true;
            this.txtTenCongViec.Size = new System.Drawing.Size(227, 26);
            this.txtTenCongViec.TabIndex = 5;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.EditValue = null;
            this.txtNgayHetHan.Location = new System.Drawing.Point(137, 150);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNgayHetHan.Properties.Appearance.Options.UseFont = true;
            this.txtNgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.DisplayFormat.FormatString = "";
            this.txtNgayHetHan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.EditFormat.FormatString = "";
            this.txtNgayHetHan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.Mask.EditMask = "";
            this.txtNgayHetHan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayHetHan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNgayHetHan.Size = new System.Drawing.Size(227, 26);
            this.txtNgayHetHan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thêm công việc";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(20, 379);
            this.gridControl1.MainView = this.gvDSNhanVien;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(364, 223);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSNhanVien});
            // 
            // gvDSNhanVien
            // 
            this.gvDSNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTenNV,
            this.gridColumnMoTa});
            this.gvDSNhanVien.GridControl = this.gridControl1;
            this.gvDSNhanVien.Name = "gvDSNhanVien";
            this.gvDSNhanVien.OptionsView.ShowGroupPanel = false;
            this.gvDSNhanVien.OptionsView.ShowIndicator = false;
            // 
            // gridColumnTenNV
            // 
            this.gridColumnTenNV.Caption = "Họ Tên";
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ tên", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            repositoryItemLookUpEdit1.DisplayMember = "HoTen";
            repositoryItemLookUpEdit1.Name = "HoTenEditor";
            repositoryItemLookUpEdit1.NullText = "Chọn nhân viên";
            repositoryItemLookUpEdit1.ValueMember = "MaNhanVien";
            this.gridColumnTenNV.ColumnEdit = repositoryItemLookUpEdit1;
            this.gridColumnTenNV.FieldName = "HoTen";
            this.gridColumnTenNV.Name = "gridColumnTenNV";
            this.gridColumnTenNV.Visible = true;
            this.gridColumnTenNV.VisibleIndex = 0;
            // 
            // gridColumnMoTa
            // 
            this.gridColumnMoTa.Caption = "Mô tả";
            this.gridColumnMoTa.FieldName = "MoTa";
            this.gridColumnMoTa.Name = "gridColumnMoTa";
            this.gridColumnMoTa.Visible = true;
            this.gridColumnMoTa.VisibleIndex = 1;
            // 
            // btnThemNV
            // 
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(20, 577);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(105, 25);
            this.btnThemNV.TabIndex = 11;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(312, 618);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 34);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMoTa.Location = new System.Drawing.Point(137, 235);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(227, 93);
            this.txtMoTa.TabIndex = 13;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(225, 618);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 34);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbDuAn
            // 
            this.cbbDuAn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbDuAn.FormattingEnabled = true;
            this.cbbDuAn.Location = new System.Drawing.Point(137, 192);
            this.cbbDuAn.Name = "cbbDuAn";
            this.cbbDuAn.Size = new System.Drawing.Size(227, 22);
            this.cbbDuAn.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(28, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.EditValue = null;
            this.txtNgayBatDau.Location = new System.Drawing.Point(137, 108);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNgayBatDau.Properties.Appearance.Options.UseFont = true;
            this.txtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Properties.DisplayFormat.FormatString = "";
            this.txtNgayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBatDau.Properties.EditFormat.FormatString = "";
            this.txtNgayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBatDau.Properties.Mask.EditMask = "";
            this.txtNgayBatDau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayBatDau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNgayBatDau.Properties.EditValueChanged += new System.EventHandler(this.txtNgayBatDau_Properties_EditValueChanged);
            this.txtNgayBatDau.Size = new System.Drawing.Size(227, 26);
            this.txtNgayBatDau.TabIndex = 17;
            // 
            // ucThemCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.cbbDuAn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenCongViec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayHetHan);
            this.Name = "ucThemCongViec";
            this.Size = new System.Drawing.Size(405, 682);
            this.Load += new System.EventHandler(this.ucThemCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtTenCongViec;
        private DevExpress.XtraEditors.DateEdit txtNgayHetHan;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMoTa;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ComboBox cbbDuAn;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit txtNgayBatDau;
    }
}
