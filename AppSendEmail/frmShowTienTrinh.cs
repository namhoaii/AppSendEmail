using AppSendEmail.Enums;
using AppSendEmail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AppSendEmail
{
    public partial class frmShowTienTrinh : DevExpress.XtraEditors.XtraForm
    {
        InfoSend info;
        List<SendEmail> log;
        string gmailGui;
        string appPassword;

        private bool isThreadRunning = true;

        private bool allowFormClose = false;

        public frmShowTienTrinh(InfoSend _info, string gmailGui, string appPassword)
        {
            InitializeComponent();
            info = _info;
            log = new List<SendEmail>();
            this.gmailGui = gmailGui;
            this.appPassword = appPassword;
        }

        private void ShowGrid()
        {
            foreach(string e in info.DSEmail)
            {
                if (!isThreadRunning)
                    break;
                // Thêm phần tử vào danh sách
                lock (log)
                {
                    log.Insert(0, new SendEmail() { NguoiNhan = e, ThoiGianGui = DateTime.Now, TrangThai = TrangThai.DangTienHanh });

                    /*lblDC.Invoke(new Action(() => lblDC.Text = (int.Parse(lblDC.Text) - 1).ToString()));*/
                    if (lblDC.InvokeRequired)
                    {
                        lblDC.Invoke(new Action(() => lblDC.Text = (int.Parse(lblDC.Text) - 1).ToString()));
                    }
                    gvShowData.RefreshData();

                    try
                    {
                        ITNHelpers.SendEmail.Send(info.TieuDe, info.NoiDung, gmailGui, appPassword, e, info.DSFileDinhKem);
                        log[0].TrangThai = TrangThai.HoanThanh;
                        gvShowData.RefreshData();
                    }
                    catch (Exception)
                    {
                        log[0].TrangThai = TrangThai.Loi;
                        gvShowData.RefreshData();
                    }

                    
                }
                //gvShowData.RefreshData();
                Thread.Sleep(info.Delay);
            }

            var kq = MessageBox.Show("Đã hoàn thành", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (kq == DialogResult.OK)
            {
                this.Invoke(new Action(() =>
                {
                    allowFormClose = true;
                    this.Close();
                }));
            }    
        }

        private void frmShowTienTrinh_Load(object sender, EventArgs e)
        {
            gcShowData.DataSource = log;
            lblDC.Text = info.DSEmail.Count().ToString();
            Thread t = new Thread(ShowGrid); t.Start();
            t.IsBackground = true;
        }

        private void gvShowData_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "gctTrangThai" && e.CellValue != null)
            {
                if (e.CellValue.ToString() == "HoanThanh")
                {
                    var img = Properties.Resources.success_20px;
                    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                    e.Handled = true;
                }
                else if (e.CellValue.ToString() == "Loi")
                {
                    var img = Properties.Resources.error_20px;
                    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                    e.Handled = true;
                }
                else
                {
                    var img = Properties.Resources.load_20px;
                    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                    e.Handled = true;
                }
            }
        }

        private void frmShowTienTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!allowFormClose)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc muốn dừng tiến trình hiện tại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq == DialogResult.Yes)
            {
                isThreadRunning = false;
            }
        }
    }
}