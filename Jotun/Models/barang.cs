using System;
using System.Collections.Generic;

namespace Jotun.Models
{
    public partial class barang
    {
        public barang()
        {
            this.detailpos = new List<detailpo>();
            this.detail_surat_jalans = new List<detail_surat_jalan>();
            this.detail_invoices = new List<detail_invoice>();
        }

        public string kd_barang { get; set; }
        public string nama { get; set; }
        public string no_batch { get; set; }
        public string tipe { get; set; }
        public double ukuran { get; set; }
        public Nullable<int> harga { get; set; }
        public Nullable<int> stok { get; set; }

        public ICollection<detail_penerimaan> detail_penerimaans { get; set; }
        public ICollection<detailpo> detailpos { get; set; }
        public ICollection<detail_surat_jalan> detail_surat_jalans { get; set; }
        public ICollection<detail_invoice> detail_invoices { get; set; }
        public ICollection<detail_po_pusat> detail_po_pusats { get; set; }
    }
}
