using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSendEmail
{
    public partial class frmTroGiup : DevExpress.XtraEditors.XtraForm
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void lblXThuc_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/signinoptions/two-step-verification/enroll-welcome?hl=vi");
        }

        private void lblTaoPass_Click(object sender, EventArgs e)
        {
            Process.Start("https://myaccount.google.com/u/2/apppasswords?utm_source=google-account&utm_medium=myaccountsecurity&utm_campaign=tsv-settings&rapt=AEjHL4OHQIgW2Ska7Pdp1dyzVlavjMf9Q1WymyXqeMewNb3hGKHSg-yGKEKVxK7IjzUc4l5Ej_OXaWEmyHfh-e9qUrmxWbwVwCoAAflMo03_gks-2_h9wwE");
        }
    }
}