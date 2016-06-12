using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class poMap : EntityTypeConfiguration<po>
    {
        public poMap()
        {
            HasKey(t => t.no_po);

            this.Property(t => t.kd_customer)
                .HasMaxLength(7);
            this.Property(t => t.tgl);
            this.Property(t => t.term)
                .HasMaxLength(30);
            this.Property(t => t.project)
                .HasMaxLength(40);
            this.Property(t => t.sub_total);
            this.Property(t => t.ppn);
            this.Property(t => t.total);

            this.ToTable("po");
            this.Property(t => t.no_po).HasColumnName("no_po");
            this.Property(t => t.kd_customer).HasColumnName("kd_customer");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.term).HasColumnName("term");
            this.Property(t => t.project).HasColumnName("project");
            this.Property(t => t.sub_total).HasColumnName("sub_total");
            this.Property(t => t.ppn).HasColumnName("ppn");
            this.Property(t => t.total).HasColumnName("total");

            this.HasOptional(t => t.customer).WithMany(t => t.pos).HasForeignKey(t => t.kd_customer);
        }
    }
}
