using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class detail_surat_jalan
    {
        public int kd_detail_surat_jalan { get; set; }
        public int qty { get; set; }
        public double ukuran { get; set; }
        public double total_ukuran { get; set; }
        public string no_surat_jalan { get; set; }
        public string kd_barang { get; set; }

        public virtual surat_jalan surat_jalan { get; set; }
        public virtual barang barang { get; set; }
    }
}
