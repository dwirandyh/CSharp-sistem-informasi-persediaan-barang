using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Jotun.Models.Mapping;

namespace Jotun.Models
{
    public partial class jotunContext : DbContext
    {
        static jotunContext()
        {
            Database.SetInitializer<jotunContext>(null);
        }

        public jotunContext()
            : base("Name=jotunContext")
        {
            // menonaktifkan lazy loading
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<barang> barangs { get; set; }
        public DbSet<karyawan> karyawans { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<detailpo> detailpo { get; set; }
        public DbSet<po> po { get; set; }
        public DbSet<surat_jalan> surat_jalan { get; set; }
        public DbSet<detail_surat_jalan> detail_surat_jalan { get; set; }
        public DbSet<invoice> invoice { get; set; }
        public DbSet<detail_invoice> detail_invoice { get; set; }
        public DbSet<penerimaan> penerimaan { get; set; }
        public DbSet<detail_penerimaan> detail_penerimaan { get; set; }
        public DbSet<po_pusat> po_pusat { get; set; }
        public DbSet<detail_po_pusat> detail_po_pusat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new barangMap());
            modelBuilder.Configurations.Add(new karyawanMap());
            modelBuilder.Configurations.Add(new customerMap());
            modelBuilder.Configurations.Add(new penerimaanMap());
            modelBuilder.Configurations.Add(new detail_penerimaanMap());
            modelBuilder.Configurations.Add(new poMap());
            modelBuilder.Configurations.Add(new detailpoMap());
            modelBuilder.Configurations.Add(new surat_jalanMap());
            modelBuilder.Configurations.Add(new detail_surat_jalanMap());
            modelBuilder.Configurations.Add(new invoiceMap());
            modelBuilder.Configurations.Add(new detail_invoiceMap());
            modelBuilder.Configurations.Add(new po_pusatMap());
            modelBuilder.Configurations.Add(new detail_po_pusatMap());
        }
    }
}
