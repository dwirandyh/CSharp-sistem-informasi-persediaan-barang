using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class po_pusatMap : EntityTypeConfiguration<po_pusat>
    {
        public po_pusatMap()
        {
            HasKey(t => t.no_po);

            this.Property(t => t.tgl);
            this.Property(t => t.term)
                .HasMaxLength(30);
            this.Property(t => t.project)
                .HasMaxLength(40);
            this.Property(t => t.sub_total);
            this.Property(t => t.ppn);
            this.Property(t => t.total);

            this.ToTable("po_pusat");
            this.Property(t => t.no_po).HasColumnName("no_po");
            this.Property(t => t.tgl).HasColumnName("tgl");
            this.Property(t => t.term).HasColumnName("term");
            this.Property(t => t.project).HasColumnName("project");
            this.Property(t => t.sub_total).HasColumnName("sub_total");
            this.Property(t => t.ppn).HasColumnName("ppn");
            this.Property(t => t.total).HasColumnName("total");
        }
    }
}
