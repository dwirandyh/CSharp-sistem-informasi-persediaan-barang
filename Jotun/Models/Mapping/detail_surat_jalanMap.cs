using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class detail_surat_jalanMap : EntityTypeConfiguration<detail_surat_jalan>
    {
        public detail_surat_jalanMap()
        {
            this.HasKey(t => t.kd_detail_surat_jalan);

            this.Property(t => t.no_surat_jalan)
                .HasMaxLength(20);
            this.Property(t => t.kd_barang)
                .HasMaxLength(7);
            this.Property(t => t.qty);
            this.Property(t => t.ukuran);
            this.Property(t => t.total_ukuran);

            this.ToTable("detail_surat_jalan", "jotun");
            this.Property(t => t.kd_detail_surat_jalan).HasColumnName("kd_detail_surat_jalan");
            this.Property(t => t.no_surat_jalan).HasColumnName("no_surat_jalan");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.ukuran).HasColumnName("ukuran");
            this.Property(t => t.total_ukuran).HasColumnName("total_ukuran");

            this.HasOptional(t => t.surat_jalan)
                .WithMany(t => t.detail_surat_jalans)
                .HasForeignKey(t => t.no_surat_jalan);
            this.HasOptional(t => t.barang)
                .WithMany(t => t.detail_surat_jalans)
                .HasForeignKey(t => t.kd_barang);
        }
    }
}
