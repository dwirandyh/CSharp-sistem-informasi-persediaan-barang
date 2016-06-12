using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Jotun.Controllers
{
    class CCustomer
    {
        public static List<Models.customer> get_data()
        {
            using (var db = new Models.jotunContext())
            {
                return db.customers.ToList();
            }
        }

        public static Models.customer get_detail(string kode)
        {
            using (var db = new Models.jotunContext())
            {
                return db.customers.Where(t => t.kd_customer == kode).SingleOrDefault();
            }
        }

        public static string get_kode()
        {
            using (var db = new Models.jotunContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('CST','customer', 'kd_customer')").SingleOrDefault();
            }
        }

        public static List<Models.customer> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.jotunContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.customers.Where(t => t.kd_customer.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.customers.Where(t => t.nama.Contains(param)).ToList();
                }
                else if (kolom.Contains("alamat"))
                {
                    return db.customers.Where(t => t.alamat.Contains(param)).ToList();
                }
                else if (kolom.Contains("telepon"))
                {
                    return db.customers.Where(t => t.no_telepon.ToString().Contains(param)).ToList();
                }
                else
                {
                    return db.customers.Where(t => t.email.Contains(param)).ToList();
                }
            }
        }

        public static bool insert(Models.customer data)
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

        public static bool update(Models.customer data)
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

        public static bool delete(Models.customer data)
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
