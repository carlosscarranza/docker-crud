using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CrudmySQL.Models
{
    public partial class BgAJ759B8lContext : DbContext
    {
        //public BgAJ759B8lContext()
        //{
        //}

        public BgAJ759B8lContext(DbContextOptions<BgAJ759B8lContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=remotemysql.com;Database=BgAJ759B8l;Uid=BgAJ759B8l;Pwd=eMcgOm4bca;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("personas");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(255)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(255)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.Programa)
                    .HasMaxLength(255)
                    .HasColumnName("PROGRAMA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
