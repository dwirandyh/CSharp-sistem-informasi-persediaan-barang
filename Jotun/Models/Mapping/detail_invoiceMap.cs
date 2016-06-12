using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class detail_invoiceMap : EntityTypeConfiguration<detail_invoice>
    {
        public detail_invoiceMap()
        {
            HasKey(t => t.kd_detail_invoice);

            this.Property(t => t.no_invoice)
                .HasMaxLength(20);
            this.Property(t => t.kd_barang)
                .HasMaxLength(7);
            this.Property(t => t.qty);
            this.Property(t => t.liter);
            this.Property(t => t.harga);
            this.Property(t => t.total);

            this.ToTable("detail_invoice", "jotun");
            this.Property(t => t.kd_detail_invoice).HasColumnName("kd_detail_invoice");
            this.Property(t => t.no_invoice).HasColumnName("no_invoice");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.liter).HasColumnName("liter");
            this.Property(t => t.harga).HasColumnName("harga");
            this.Property(t => t.total).HasColumnName("total");

            this.HasOptional(t => t.barang)
                .WithMany(t => t.detail_invoices)
                .HasForeignKey(t => t.kd_barang);

            this.HasOptional(t => t.invoice)
                .WithMany(t => t.detail_invoices)
                .HasForeignKey(t => t.no_invoice);
        }
    }
}
