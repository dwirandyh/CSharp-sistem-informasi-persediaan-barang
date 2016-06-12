using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class customer
    {
        public customer()
        {
            this.pos = new List<po>();
            this.surat_jalans = new List<surat_jalan>();
            this.invoices = new List<invoice>();
        }

        public string kd_customer { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_telepon { get; set; }
        public string email { get; set; }
        public string status { get; set;}
        public double diskon { get; set; }

        public ICollection<po> pos { get; set; }
        public ICollection<surat_jalan> surat_jalans { get; set; }
        public ICollection<invoice> invoices { get; set; }
    }
}
