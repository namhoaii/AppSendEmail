using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSendEmail
{
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Gmail = txtEmailGui.Text;
            Properties.Settings.Default.AppPassword = txtAppPass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            txtEmailGui.Text = Properties.Settings.Default.Gmail;
            txtAppPass.Text = Properties.Settings.Default.AppPassword;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            txtAppPass.Properties.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}