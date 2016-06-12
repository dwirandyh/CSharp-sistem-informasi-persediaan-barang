using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class surat_jalanMap : EntityTypeConfiguration<surat_jalan>
    {
        public surat_jalanMap()
        {
            // Primary key
            this.HasKey(t => t.no_surat_jalan);

            this.Property(t => t.no_po)
                .HasMaxLength(30);

            this.Property(t => t.kd_customer)
                .HasMaxLength(7);

            this.Property(t => t.tgl);

            this.Property(t => t.total_ukuran);

            this.Property(t => t.po_pr);

            this.ToTable("surat_jalan", "jotun");
            this.Property(t => t.no_surat_jalan).HasColumnName("no_surat_jalan");
            this.Property(t => t.no_po).HasColumnName("no_po");
            this.Property(t => t.kd_customer).HasColumnName("kd_customer");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.total_ukuran).HasColumnName("total_ukuran");
            this.Property(t => t.po_pr).HasColumnName("po_pr");

            this.HasOptional(t => t.customer)
                .WithMany(t => t.surat_jalans)
                .HasForeignKey(t => t.kd_customer);

            this.HasOptional(t => t.po)
                .WithMany(t => t.surat_jalans)
                .HasForeignKey(t => t.no_po);
                
        }
    }
}
