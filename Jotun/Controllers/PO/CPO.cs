using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Jotun.Controllers.PO
{
    class CPO
    {
        public static DataSet1 get_report(DateTime tgl1, DateTime tgl2)
        {
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("select * from po where date(tgl) between '{0}' and '{1}'", tgl1.ToString("yyyy-MM-dd"), tgl2.ToString("yyyy-MM-dd"));
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["po"].Merge(dt);
                        }
                    }

                    var tables = new string[] { "barang", "customer", "detail_po" };
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

        public static bool insert(Models.po data)
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
