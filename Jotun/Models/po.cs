using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class po
    {
        public po()
        {
            this.detailpos = new List<Models.detailpo>();
            this.surat_jalans = new List<Models.surat_jalan>();
        }
        public string no_po { get; set; }
        public string kd_customer { get; set; }
        public DateTime tgl { get; set; }
        public string term { get; set; }
        public string project { get; set; }
        public int sub_total { get; set; }
        public int ppn { get; set; }
        public int total { get; set; }

        public virtual customer customer { get; set; }

        public ICollection<Models.detailpo> detailpos { get; set; }
        public ICollection<Models.surat_jalan> surat_jalans { get; set; }
    }
}
