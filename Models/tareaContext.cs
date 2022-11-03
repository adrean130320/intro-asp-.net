using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace introAsp.Models
{
    public partial class tareaContext : DbContext
    {
        public tareaContext()
        {
        }

        public tareaContext(DbContextOptions<tareaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cerveza> Cervezas { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-QBLTU8QO\\SQLEXPRESS;Database=tarea; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cerveza>(entity =>
            {
                entity.ToTable("cerveza");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(10)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.HasOne(d => d.MarcaNavigation)
                    .WithMany(p => p.Cervezas)
                    .HasForeignKey(d => d.Marca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cerveza_marca");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.ToTable("marca");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Marca1)
                    .HasMaxLength(20)
                    .HasColumnName("marca")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
