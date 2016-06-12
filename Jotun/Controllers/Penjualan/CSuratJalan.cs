using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Jotun.Controllers.Penjualan
{
    class CSuratJalan
    {
        public static List<Models.po> get_po()
        {
            try
            {
                using (var db = new Models.jotunContext())
                {
                    return db.po
                        .Include(t => t.customer)
                        .OrderByDescending(t => t.tgl)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.po>();
        }

        public static List<Models.detailpo> get_detail_po(string no_po)
        {
            try
            {
                using (var db = new Models.jotunContext())
                {
                    return db.detailpo
                        .Include(t => t.barang)
                        .Where(t => t.no_po == no_po)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.detailpo>();
        }

        public static string get_kode()
        {
            using (var db = new Models.jotunContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran_transaksi('SJ','surat_jalan','no_surat_jalan')").SingleOrDefault();
            }
        }

        public static DataSet1 get_report(string no_surat_jalan)
        {
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("select * from surat_jalan where no_surat_jalan = '{0}'", no_surat_jalan);
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["surat_jalan"].Merge(dt);
                        }

                        cmd.CommandText = string.Format("select * from detail_surat_jalan where no_surat_jalan = '{0}'", no_surat_jalan);
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["detail_surat_jalan"].Merge(dt);
                        }

                        cmd.CommandText = string.Format("select * from barang");
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["barang"].Merge(dt);
                        }

                        cmd.CommandText = string.Format("select * from customer");
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["customer"].Merge(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgEx(ex.Message);
            }
            return ds;
        }

        public static bool insert(Models.surat_jalan data)
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
