using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Jotun.Controllers.Penjualan
{
    public class CInvoice
    {
        public static List<Models.surat_jalan> get_surat_jalan()
        {
            try
            {
                using (var db = new Models.jotunContext())
                {
                    return db.surat_jalan
                        .Include(t => t.po)
                        .Include(t => t.po.customer)
                        .OrderByDescending(t => t.no_surat_jalan)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.surat_jalan>();
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
                return db.Database.SqlQuery<string>("CALL penomoran_transaksi('IN','invoice','no_invoice')").SingleOrDefault();
            }
        }

        public static bool insert(Models.invoice data)
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

        public static DataSet1 get_repot(string no_invoice)
        {
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("select * from invoice where no_invoice = '{0}'", no_invoice);
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["invoice"].Merge(dt);
                        }

                        cmd.CommandText = string.Format("select * from detail_invoice where no_invoice = '{0}'", no_invoice);
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["detail_invoice"].Merge(dt);
                        }

                        string[] tables = new string[] { "barang", "customer", "surat_jalan", "po" };

                        foreach (var table in tables)
                        {
                            cmd.CommandText = string.Format("select * from {0}", table);
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

        public static DataSet1 get_repot_penjualan_per_customer(string kode, DateTime tgl1, DateTime tgl2)
        {
            kode = "'" + kode.Replace(", ", "','") + "'";
            DataSet1 ds = new DataSet1();
            try
            {
                using (var db = new Models.jotunContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("select * from invoice where kd_customer in ({0}) and date(tgl) between '{1}' and '{2}'", kode, tgl1.ToString("yyyy-MM-dd"), tgl2.ToString("yyyy-MM-dd"));
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["invoice"].Merge(dt);
                        }

                        cmd.CommandText = string.Format("select * from detail_invoice");
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            ds.Tables["detail_invoice"].Merge(dt);
                        }

                        string[] tables = new string[] { "barang", "customer", "surat_jalan", "po" };

                        foreach (var table in tables)
                        {
                            cmd.CommandText = string.Format("select * from {0}", table);
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
    }
}
