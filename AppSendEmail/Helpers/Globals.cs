using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSendEmail.Helpers
{
    public static class Globals
    {
        public static bool IsFormOpen(string formName)
        {
            // Sử dụng LINQ để kiểm tra xem form có trong danh sách các form đã mở không
            return Application.OpenForms.OfType<Form>().Any(f => f.Name == formName);
        }

        public static void OpenForm(string formName)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == formName)
                {
                    frm.Show();
                    frm.Activate();
                }
            }
        }
    }
}
