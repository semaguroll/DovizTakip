using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DovizTakip.Models
{
    public partial class DovizKurContext : DbContext
    {
        public DovizKurContext()
        {
        }

        public DovizKurContext(DbContextOptions<DovizKurContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DovizKurlari> DovizKurlari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DovizKur;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DovizKurlari>(entity =>
            {
                entity.Property(e => e.Birim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KurAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParaBirimi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
