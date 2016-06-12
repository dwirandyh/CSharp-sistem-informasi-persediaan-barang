using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class customerMap : EntityTypeConfiguration<customer>
    {
        public customerMap()
        {
            HasKey(t => t.kd_customer);

            this.Property(t => t.nama)
                .HasMaxLength(40);

            this.Property(t => t.alamat)
                .HasMaxLength(300);

            this.Property(t => t.no_telepon)
                .HasMaxLength(20);

            this.Property(t => t.email)
                .HasMaxLength(50);

            ToTable("customer");

            this.Property(t => t.kd_customer).HasColumnName("kd_customer");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.alamat).HasColumnName("alamat");
            this.Property(t => t.no_telepon).HasColumnName("no_telepon");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.diskon).HasColumnName("diskon");
        }
    }
}
