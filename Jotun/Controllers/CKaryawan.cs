using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Jotun.Controllers
{
    class CKaryawan
    {
        public static List<Models.karyawan> get_data()
        {
            using (var db = new Models.jotunContext())
            {
                return db.karyawans.ToList();
            }
        }

        public static Models.karyawan get_detail(string kode)
        {
            using (var db = new Models.jotunContext())
            {
                return db.karyawans.Where(t => t.kd_karyawan == kode).SingleOrDefault();
            }
        }

        public static string get_kode()
        {
            using (var db = new Models.jotunContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('KRY','karyawan', 'kd_karyawan')").SingleOrDefault();
            }
        }

        public static List<Models.karyawan> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.jotunContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.karyawans.Where(t => t.kd_karyawan.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.karyawans.Where(t => t.nama.Contains(param)).ToList();
                }
                else if (kolom.Contains("alamat"))
                {
                    return db.karyawans.Where(t => t.alamat.Contains(param)).ToList();
                }
                else if (kolom.Contains("email"))
                {
                    return db.karyawans.Where(t => t.email.Contains(param)).ToList();
                }
                else
                {
                    return db.karyawans.Where(t => t.username.Contains(param)).ToList();
                }
            }
        }

        public static Models.karyawan check_login(string username,string password)
        {
            var result = new Models.karyawan();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    return db.karyawans.Where(t => t.username == username && t.password == password).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static bool insert(Models.karyawan data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Entry(data).State = EntityState.Added;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static bool update(Models.karyawan data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Entry(data).State = EntityState.Modified;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static bool delete(Models.karyawan data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }
    }
}
