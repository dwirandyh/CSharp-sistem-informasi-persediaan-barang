using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Jotun.Controllers
{
    class CBarang
    {
        public static List<Models.barang> get_data()
        {
            using (var db = new Models.jotunContext())
            {
                return db.barangs.ToList();
            }
        }

        public static Models.barang get_detail(string kode)
        {
            using (var db = new Models.jotunContext())
            {
                return db.barangs.Where(t => t.kd_barang == kode).SingleOrDefault();
            }
        }

        public static string get_kode()
        {
            using (var db = new Models.jotunContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('BRG','barang', 'kd_barang')").SingleOrDefault();
            }
        }

        public static DataSet1 get_report()
        {
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = "select * from view_barang order by terjual desc";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["view_barang"].Merge(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return ds;
        }

        public static List<Models.barang> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.jotunContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.barangs.Where(t => t.kd_barang.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.barangs.Where(t => t.nama.Contains(param)).ToList();
                }
                else if (kolom.Contains("batch"))
                {
                    return db.barangs.Where(t => t.no_batch.Contains(param)).ToList();
                }
                else if (kolom.Contains("tipe"))
                {
                    return db.barangs.Where(t => t.tipe.Contains(param)).ToList();
                }
                else if (kolom.Contains("ukuran"))
                {
                    return db.barangs.Where(t => t.ukuran.ToString().Contains(param)).ToList();
                }
                else
                {
                    return db.barangs.Where(t => t.stok.ToString().Contains(param)).ToList();
                }
            }
        }

        public static bool insert(Models.barang data)
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

        public static bool update(Models.barang data)
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

        public static bool delete(Models.barang data)
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
