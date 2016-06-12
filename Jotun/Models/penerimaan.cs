using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class penerimaan
    {
        public penerimaan()
        {
            this.detail_penerimaans = new List<detail_penerimaan>();
        }

        public string no_penerimaan { get; set; }
        public DateTime date { get; set; }
        public DateTime order_date { get; set; }
        public DateTime delivery_date { get; set; }
        public string incoterm { get; set; }
        public int order_number { get; set; }
        public string ship_from { get; set; }
        public string haulier { get; set; }
        public string vat_reg { get; set; }
        public string ship_to { get; set; }
        public double total_liter { get; set; }
        public double total_qty { get; set; }

        public ICollection<detail_penerimaan> detail_penerimaans { get; set; }
    }
}
