using System;
using System.Collections.Generic;

namespace Jotun.Models
{
    public partial class karyawan
    {
        public string kd_karyawan { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_telepon { get; set; }
        public string email { get; set; }
        public string hak_akses { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
