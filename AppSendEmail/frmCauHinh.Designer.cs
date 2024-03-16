namespace AppSendEmail
{
    partial class frmCauHinh
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
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtAppPass = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailGui = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkShow = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailGui.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(175, 139);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtAppPass
            // 
            this.txtAppPass.Location = new System.Drawing.Point(175, 84);
            this.txtAppPass.Name = "txtAppPass";
            this.txtAppPass.Properties.UseSystemPasswordChar = true;
            this.txtAppPass.Size = new System.Drawing.Size(176, 22);
            this.txtAppPass.TabIndex = 1;
            // 
            // txtEmailGui
            // 
            this.txtEmailGui.Location = new System.Drawing.Point(175, 42);
            this.txtEmailGui.Name = "txtEmailGui";
            this.txtEmailGui.Size = new System.Drawing.Size(176, 22);
            this.txtEmailGui.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "App password:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Gmail gửi:";
            // 
            // chkShow
            // 
            this.chkShow.Location = new System.Drawing.Point(290, 112);
            this.chkShow.Name = "chkShow";
            this.chkShow.Properties.Caption = "Show";
            this.chkShow.Size = new System.Drawing.Size(61, 20);
            this.chkShow.TabIndex = 21;
            this.chkShow.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // frmCauHinh
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 236);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtAppPass);
            this.Controls.Add(this.txtEmailGui);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = global::AppSendEmail.Properties.Resources.setting2;
            this.MaximizeBox = false;
            this.Name = "frmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.Load += new System.EventHandler(this.frmCauHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAppPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailGui.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtAppPass;
        private DevExpress.XtraEditors.TextEdit txtEmailGui;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkShow;
    }
}