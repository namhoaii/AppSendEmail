using AppSendEmail.Enums;
using AppSendEmail.Helpers;
using AppSendEmail.Models;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSendEmail
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {

        private IEnumerable<string> listEmails;
        private IEnumerable<string> listFiles;

        public frmMain()
        {
            InitializeComponent();
        }
            
        private void RefreshAllControl()
        {
            txtDelay.Value = 2000;
            txtTieuDe.Text = string.Empty;
            kEditor1.Html = string.Empty;
            listEmails = null;
            listFiles = null;
            lblSoFileDinhKem.Text = "0 files";
            lblSoGmail.Text = "0";
        }

        private void btnChonFileEmail_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn file text";
            openFile.Filter = "File text or excel|*.txt;*.xlsx";

            openFile.FileOk += (s, ev) =>
            {
                if (openFile.FileNames.Length > 0)
                {
                    foreach (string fileName in openFile.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Kích thước file vượt quá giới hạn (5 MB). Chọn file khác.", "Thông báo");
                            ev.Cancel = true;
                            return;
                        }
                    }
                }
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager2.ShowWaitForm();
                try
                {
                    IEnumerable<string> data;

                    if(Path.GetExtension(openFile.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        //file text
                        data = ReadFile.ReadFileByLine(openFile.FileName);
                    }
                    else
                    {
                        //file excel
                        data = ReadFile.ReadFileExcelByFirstColumn(openFile.FileName);
                    }

                    listEmails = data;
                    lblSoGmail.Text = data.Count().ToString();
                    Thread.Sleep(1000);
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng chọn lại file khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    splashScreenManager2.CloseWaitForm();
                }

            }
        }

        private void btnChonFileDinhKem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn file đính kèm";
            openFile.Filter = "All file|*.*";
            openFile.Multiselect = true;

            openFile.FileOk += (s, ev) =>
            {
                if (openFile.FileNames.Length > 0)
                {
                    foreach (string fileName in openFile.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        // Kiểm tra kích thước file (5 MB)
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Kích thước file vượt quá giới hạn (5 MB). Chọn file khác.", "Thông báo");
                            ev.Cancel = true;
                            return;
                        }
                    }
                }
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblSoFileDinhKem.Text = openFile.FileNames.Length.ToString() + " files";
                    listFiles = openFile.FileNames;
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng chọn lại file khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (Globals.IsFormOpen("frmShowTienTrinh"))
            {
                MessageBox.Show("Đã có tiến trình đang hoạt động. Vui lòng chờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Globals.OpenForm("frmShowTienTrinh");
                return;
            }

            string emailGui = Properties.Settings.Default.Gmail;
            string appPass = Properties.Settings.Default.AppPassword;
            var body = kEditor1.Html;

            if (string.IsNullOrEmpty(emailGui) || string.IsNullOrEmpty(appPass))
            {
                MessageBox.Show("Vui lòng vào mục Cấu hình để tiến hành nhập thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;
            }

            if(listEmails == null)
            {
                MessageBox.Show("Vui lòng chọn DS mail cần gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(txtTieuDe.Text) || string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thônng tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InfoSend info = new InfoSend()
            {
                TieuDe = txtTieuDe.Text,
                NoiDung = body,
                Delay = (int)txtDelay.Value,
                DSEmail = listEmails,
                DSFileDinhKem = listFiles
            };
            notifyIcon1.ShowBalloonTip(5000);
            frmShowTienTrinh f = new frmShowTienTrinh(info, emailGui, appPass);
            f.Show();
            RefreshAllControl();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTroGiup f = new frmTroGiup();
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCauHinh f = new frmCauHinh();
            f.ShowDialog(this);
        }

        private void xemTiếnTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.IsFormOpen("frmShowTienTrinh"))
            {
                MessageBox.Show("Không có tiến trình đang hoạt động. Hãy tạo tiến trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Globals.OpenForm("frmShowTienTrinh");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshAllControl();
        }
    }
}