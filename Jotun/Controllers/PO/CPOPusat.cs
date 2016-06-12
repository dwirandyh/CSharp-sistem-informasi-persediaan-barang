using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Jotun.Controllers.PO
{
    class CPOPusat
    {
        public static DataSet1 get_report(string no_po)
        {
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("SELECT * FROM po_pusat WHERE no_po ='{0}'", no_po);
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["po_pusat"].Merge(dt);
                        }
                    }

                    var tables = new string[] { "barang", "customer", "detail_po_pusat" };
                    foreach (var table in tables)
                    {
                        using (var cmd = db.Database.Connection.CreateCommand())
                        {
                            cmd.CommandText = string.Format("select * from {0} ", table);
                            cmd.CommandType = System.Data.CommandType.Text;
                            using (var reader = cmd.ExecuteReader())
                            {
                                var dt = new System.Data.DataTable();
                                dt.Load(reader);
                                ds.Tables[table].Merge(dt);
                            }
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

        public static string get_kode()
        {
            using (var db = new Models.jotunContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran_transaksi('PO','po_pusat','no_po')").SingleOrDefault();
            }
        }

        public static bool insert(Models.po_pusat data)
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
    }
}
