using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models
{
    public class detail_po_pusatMap : EntityTypeConfiguration<detail_po_pusat>
    {
        public detail_po_pusatMap()
        {
            this.HasKey(t => t.kd_detail_po);

            this.Property(t => t.no_po)
                .HasMaxLength(30);
            this.Property(t => t.kd_barang)
                .HasMaxLength(7);
            this.Property(t => t.qty);
            this.Property(t => t.liter);
            this.Property(t => t.harga);
            this.Property(t => t.total);

            // Table & Column Mappings
            this.ToTable("detail_po_pusat", "jotun");
            this.Property(t => t.kd_detail_po).HasColumnName("kd_detail_po_pusat");
            this.Property(t => t.no_po).HasColumnName("no_po");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.liter).HasColumnName("liter");
            this.Property(t => t.harga).HasColumnName("harga");
            this.Property(t => t.total).HasColumnName("total");

            this.HasOptional(t => t.po_pusat)
                .WithMany(t => t.detail_po_pusats)
                .HasForeignKey(t => t.no_po);

            this.HasOptional(t => t.barang)
                .WithMany(t => t.detail_po_pusats)
                .HasForeignKey(t => t.kd_barang);
        }
    }
}
