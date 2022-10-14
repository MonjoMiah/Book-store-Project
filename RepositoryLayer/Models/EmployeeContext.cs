using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RepositoryLayer.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Tblemployee> Tblemployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Employee;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.Dcode)
                    .HasName("PK__Designat__7AB5BC79C5C974C5");

                entity.ToTable("Designation");

                entity.Property(e => e.Dcode).HasColumnName("DCode");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DName");
            });

            modelBuilder.Entity<Tblemployee>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__tblemplo__A25C5AA6A4314300");

                entity.ToTable("tblemployee");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DcodeNavigation)
                    .WithMany(p => p.Tblemployees)
                    .HasForeignKey(d => d.Dcode)
                    .HasConstraintName("FK__tblemploy__Dcode__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
