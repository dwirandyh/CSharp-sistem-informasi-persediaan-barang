using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class detail_penerimaanMap : EntityTypeConfiguration<detail_penerimaan>
    {
        public detail_penerimaanMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_detail_penerimaan);

            // Properties
            this.Property(t => t.no_penerimaan)
                .HasMaxLength(30);
            this.Property(t => t.kd_barang)
                .HasMaxLength(7);
            this.Property(t => t.qty);
            this.Property(t => t.ukuran);
            this.Property(t => t.total);

            this.ToTable("detail_penerimaan", "jotun");
            this.Property(t => t.kd_detail_penerimaan).HasColumnName("kd_detail_penerimaan");
            this.Property(t => t.no_penerimaan).HasColumnName("no_penerimaan");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.ukuran).HasColumnName("ukuran");
            this.Property(t => t.total).HasColumnName("total");

            this.HasOptional(t => t.penerimaan)
                .WithMany(t => t.detail_penerimaans)
                .HasForeignKey(t => t.no_penerimaan);

            this.HasOptional(t => t.barang)
                .WithMany(t => t.detail_penerimaans)
                .HasForeignKey(t => t.kd_barang);
        }
    }
}
