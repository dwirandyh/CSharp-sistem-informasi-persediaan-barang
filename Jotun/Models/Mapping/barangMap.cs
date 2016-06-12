using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Jotun.Models.Mapping
{
    public class barangMap : EntityTypeConfiguration<barang>
    {
        public barangMap()
        {
            // Primary Key
            this.HasKey(t => t.kd_barang);

            // Properties
            this.Property(t => t.kd_barang)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.nama)
                .HasMaxLength(50);

            this.Property(t => t.no_batch)
                .HasMaxLength(40);

            this.Property(t => t.tipe)
                .HasMaxLength(30);

            this.Property(t => t.ukuran);
               

            // Table & Column Mappings
            this.ToTable("barang", "jotun");
            this.Property(t => t.kd_barang).HasColumnName("kd_barang");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.no_batch).HasColumnName("no_batch");
            this.Property(t => t.tipe).HasColumnName("tipe");
            this.Property(t => t.ukuran).HasColumnName("ukuran");
            this.Property(t => t.harga).HasColumnName("harga");
            this.Property(t => t.stok).HasColumnName("stok");
        }
    }
}
