using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class detail_penerimaan
    {
        public int kd_detail_penerimaan { get; set; }
        public string no_penerimaan { get; set; }
        public string kd_barang { get; set; }
        public int qty { get; set; }
        public double ukuran { get; set; }
        public double total { get; set; }

        public virtual penerimaan penerimaan { get; set; }
        public virtual barang barang { get; set; }
    }
}
