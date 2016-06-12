using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class penerimaanMap : EntityTypeConfiguration<penerimaan>
    {
        public penerimaanMap()
        {
            // Primary Key
            this.HasKey(t => t.no_penerimaan);

            this.Property(t => t.date);
            this.Property(t => t.order_date);
            this.Property(t => t.incoterm)
                .HasMaxLength(30);
            this.Property(t => t.order_number);
            this.Property(t => t.ship_from)
                .HasMaxLength(20);
            this.Property(t => t.haulier)
                .HasMaxLength(40);
            this.Property(t => t.vat_reg)
                .HasMaxLength(40);
            this.Property(t => t.ship_to)
                .HasMaxLength(20);

            this.ToTable("penerimaan", "jotun");
            this.Property(t => t.no_penerimaan).HasColumnName("no_penerimaan");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.order_date).HasColumnName("order_date");
            this.Property(t => t.delivery_date).HasColumnName("delivery_date");
            this.Property(t => t.incoterm).HasColumnName("incoterm");
            this.Property(t => t.order_number).HasColumnName("order_number");
            this.Property(t => t.ship_from).HasColumnName("ship_from");
            this.Property(t => t.haulier).HasColumnName("haulier");
            this.Property(t => t.vat_reg).HasColumnName("vat_reg");
            this.Property(t => t.ship_to).HasColumnName("ship_to");
            this.Property(t => t.total_qty).HasColumnName("total_qty");
            this.Property(t => t.total_liter).HasColumnName("total_liter");
        }
    }
}
