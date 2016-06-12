using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class invoiceMap : EntityTypeConfiguration<invoice>
    {
        public invoiceMap()
        {
            HasKey(t => t.no_invoice);

            this.Property(t => t.tgl);
            this.Property(t => t.no_surat_jalan).HasMaxLength(20);
            this.Property(t => t.kd_customer).HasMaxLength(7);
            this.Property(t => t.total_bayar);
            this.Property(t => t.total);
            this.Property(t => t.diskon);
            this.Property(t => t.total_liter);

            this.ToTable("invoice", "jotun");
            this.Property(t => t.no_invoice).HasColumnName("no_invoice");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.no_surat_jalan).HasColumnName("no_surat_jalan");
            this.Property(t => t.kd_customer).HasColumnName("kd_customer");
            this.Property(t => t.total_bayar).HasColumnName("total_bayar");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.diskon).HasColumnName("diskon");
            this.Property(t => t.total_liter).HasColumnName("total_liter");

            this.HasOptional(t => t.customer)
                .WithMany(t => t.invoices)
                .HasForeignKey(t => t.kd_customer);

            this.HasOptional(t => t.surat_jalan)
                .WithMany(t => t.invoices)
                .HasForeignKey(t => t.no_surat_jalan);
        }
    }
}
