using AppSendEmail.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSendEmail.Models
{
    public class SendEmail
    {
        public string NguoiNhan { get; set; }
        public DateTime ThoiGianGui { get; set; }
        public TrangThai TrangThai { get; set; }
    }
}
