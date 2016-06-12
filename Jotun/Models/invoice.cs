using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class invoice
    {
        public invoice()
        {
            this.detail_invoices = new List<detail_invoice>();
        }

        public string no_invoice { get; set; }
        public DateTime tgl { get; set; }
        public string no_surat_jalan { get; set; }
        public string kd_customer { get; set; }
        public double total_liter { get; set; }
        public int total { get; set; }
        public int diskon { get; set; }
        public int total_bayar { get; set; }

        public virtual customer customer { get; set; }
        public virtual surat_jalan surat_jalan { get; set; }

        public ICollection<detail_invoice> detail_invoices { get; set; }
    }
}
