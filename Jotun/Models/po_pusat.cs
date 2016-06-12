using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class po_pusat
    {
        public po_pusat()
        {
            this.detail_po_pusats = new List<Models.detail_po_pusat>();
        }

        public string no_po { get; set; }
        public DateTime tgl { get; set; }
        public string project { get; set; }
        public string term { get; set; }
        public int sub_total { get; set; }
        public int ppn { get; set; }
        public int total { get; set; }

        public ICollection<Models.detail_po_pusat> detail_po_pusats { get; set; }
    }
}
