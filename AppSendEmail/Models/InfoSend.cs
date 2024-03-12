using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSendEmail.Models
{
    public class InfoSend
    {
        public IEnumerable<string> DSEmail { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public int Delay { get; set; }
        public IEnumerable<string> DSFileDinhKem { get; set; }
    }
}
