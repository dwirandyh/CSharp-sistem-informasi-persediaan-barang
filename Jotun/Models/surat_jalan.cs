using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class surat_jalan
    {
        public surat_jalan()
        {
            this.detail_surat_jalans = new List<detail_surat_jalan>();
            this.invoices = new List<invoice>();
        }

        public string no_surat_jalan { get; set; }
        public string no_po { get; set; }
        public string kd_customer { get; set; }
        public Nullable<System.DateTime> tgl { get; set;}
        public double total_ukuran { get; set; }
        public string po_pr { get; set; }

        public virtual customer customer { get; set; }
        public virtual po po { get; set; }

        public ICollection<detail_surat_jalan> detail_surat_jalans { get; set; }
        public ICollection<invoice> invoices { get; set;}
    }
}
