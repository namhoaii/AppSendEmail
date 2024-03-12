namespace AppSendEmail
{
    partial class frmTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroGiup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTaoPass = new DevExpress.XtraEditors.LabelControl();
            this.lblXThuc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hướng dẫn sử dụng";
            // 
            // labelControl9
            // 
            this.labelControl9.AllowHtmlString = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl9.Location = new System.Drawing.Point(47, 55);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(427, 50);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = resources.GetString("labelControl9.Text");
            // 
            // labelControl10
            // 
            this.labelControl10.AllowHtmlString = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 111);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(230, 18);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "- Thêm thông tin trong mục <b><size=11><color=3, 0, 162>Cấu hình</color></size></" +
    "b>.";
            // 
            // labelControl8
            // 
            this.labelControl8.AllowHtmlString = true;
            this.labelControl8.Location = new System.Drawing.Point(23, 31);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(295, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "- Chuẩn bị file chứa danh sách các <b><size=11><color=3, 0, 162>Gmail</color></si" +
    "ze></b> cần gửi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTaoPass);
            this.groupBox2.Controls.Add(this.lblXThuc);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 326);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lblTaoPass
            // 
            this.lblTaoPass.AllowHtmlString = true;
            this.lblTaoPass.Location = new System.Drawing.Point(299, 171);
            this.lblTaoPass.Name = "lblTaoPass";
            this.lblTaoPass.Size = new System.Drawing.Size(173, 16);
            this.lblTaoPass.TabIndex = 9;
            this.lblTaoPass.Text = "<i><color=76, 201, 165>Click vào đây để tạo mật khẩu</color></i>";
            this.lblTaoPass.Click += new System.EventHandler(this.lblTaoPass_Click);
            // 
            // lblXThuc
            // 
            this.lblXThuc.AllowHtmlString = true;
            this.lblXThuc.Location = new System.Drawing.Point(208, 149);
            this.lblXThuc.Name = "lblXThuc";
            this.lblXThuc.Size = new System.Drawing.Size(168, 16);
            this.lblXThuc.TabIndex = 10;
            this.lblXThuc.Text = "<i><color=76, 201, 165>Click vào đây để bật xác thực</color></i>";
            this.lblXThuc.Click += new System.EventHandler(this.lblXThuc_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.AllowHtmlString = true;
            this.labelControl7.Location = new System.Drawing.Point(55, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(238, 16);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "-<b>B2:</b> Tạo mật khẩu ứng dụng và sử dụng.";
            // 
            // labelControl6
            // 
            this.labelControl6.AllowHtmlString = true;
            this.labelControl6.Location = new System.Drawing.Point(55, 149);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 16);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "-<b>B1:</b> Bật xác thực 2 bước.\r\n";
            // 
            // labelControl5
            // 
            this.labelControl5.AllowHtmlString = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(225, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "<b><color=192, 65, 26>Hướng dẫn tạo mật khẩu ứng dụng</color></b>";
            // 
            // labelControl4
            // 
            this.labelControl4.AllowHtmlString = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(461, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "4. Sử dụng <b>mật khẩu ứng dụng</b> thay vì mật khẩu (vì lý do bảo mật của google" +
    ")";
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlString = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(171, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "3. Delay khuyến nghị <color=55, 148, 255>2000ms</color>.";
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(484, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "2. Tốc độ gửi của từng email phụ thuộc vào tốc độ mạng và kích thước file đính kè" +
    "m.";
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(568, 18);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "1. Khi lần đầu tiên sử dụng phần mềm vui lòng vào phần <b><size=11><color=255, 0," +
    " 0>Cấu hình</color></size></b> để thiết lập tài khoản gửi mail.\r\n";
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::AppSendEmail.Properties.Resources.help;
            this.MaximizeBox = false;
            this.Name = "frmTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ giúp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl lblTaoPass;
        private DevExpress.XtraEditors.LabelControl lblXThuc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}