namespace AppSendEmail
{
    partial class frmShowTienTrinh
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
            this.gcShowData = new DevExpress.XtraGrid.GridControl();
            this.gvShowData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gctNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctThoiGianGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDC = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // gcShowData
            // 
            this.gcShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShowData.Location = new System.Drawing.Point(0, 0);
            this.gcShowData.MainView = this.gvShowData;
            this.gcShowData.Name = "gcShowData";
            this.gcShowData.Size = new System.Drawing.Size(824, 497);
            this.gcShowData.TabIndex = 1;
            this.gcShowData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShowData});
            // 
            // gvShowData
            // 
            this.gvShowData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gctNguoiNhan,
            this.gctThoiGianGui,
            this.gctTrangThai});
            this.gvShowData.GridControl = this.gcShowData;
            this.gvShowData.Name = "gvShowData";
            this.gvShowData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvShowData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvShowData.OptionsBehavior.Editable = false;
            this.gvShowData.OptionsBehavior.ReadOnly = true;
            this.gvShowData.OptionsFind.AllowFindPanel = false;
            this.gvShowData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gvShowData.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvShowData_CustomDrawCell);
            // 
            // gctNguoiNhan
            // 
            this.gctNguoiNhan.Caption = "Người nhận";
            this.gctNguoiNhan.FieldName = "NguoiNhan";
            this.gctNguoiNhan.Name = "gctNguoiNhan";
            this.gctNguoiNhan.Visible = true;
            this.gctNguoiNhan.VisibleIndex = 0;
            // 
            // gctThoiGianGui
            // 
            this.gctThoiGianGui.Caption = "Thời gian gửi";
            this.gctThoiGianGui.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gctThoiGianGui.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gctThoiGianGui.FieldName = "ThoiGianGui";
            this.gctThoiGianGui.Name = "gctThoiGianGui";
            this.gctThoiGianGui.Visible = true;
            this.gctThoiGianGui.VisibleIndex = 1;
            // 
            // gctTrangThai
            // 
            this.gctTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.gctTrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gctTrangThai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gctTrangThai.Caption = "Trạng thái";
            this.gctTrangThai.FieldName = "TrangThai";
            this.gctTrangThai.MaxWidth = 70;
            this.gctTrangThai.Name = "gctTrangThai";
            this.gctTrangThai.Visible = true;
            this.gctTrangThai.VisibleIndex = 2;
            this.gctTrangThai.Width = 70;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(575, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Đang chờ: ";
            // 
            // lblDC
            // 
            this.lblDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblDC.Appearance.Options.UseFont = true;
            this.lblDC.Appearance.Options.UseForeColor = true;
            this.lblDC.Location = new System.Drawing.Point(644, 9);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(10, 19);
            this.lblDC.TabIndex = 3;
            this.lblDC.Text = "0";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(734, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 37);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Kết thúc";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmShowTienTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcShowData);
            this.IconOptions.Image = global::AppSendEmail.Properties.Resources.icon_1;
            this.Name = "frmShowTienTrinh";
            this.Text = "Tiến trình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShowTienTrinh_FormClosing);
            this.Load += new System.EventHandler(this.frmShowTienTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcShowData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShowData;
        private DevExpress.XtraGrid.Columns.GridColumn gctNguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gctThoiGianGui;
        private DevExpress.XtraGrid.Columns.GridColumn gctTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblDC;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}