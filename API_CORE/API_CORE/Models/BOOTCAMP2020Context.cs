using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_CORE.Models
{
    public partial class BOOTCAMP2020Context : DbContext
    {
        public BOOTCAMP2020Context()
        {
        }

        public BOOTCAMP2020Context(DbContextOptions<BOOTCAMP2020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<TblEmployees> TblEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BOOTCAMP2020;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DetailCity)
                    .HasColumnName("Detail_City")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DetailGender)
                    .HasColumnName("Detail_Gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DetailName)
                    .HasColumnName("Detail_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DetailPassword)
                    .HasColumnName("Detail_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.EmpDob)
                    .HasColumnName("EMP_DOB")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EmpName)
                    .HasColumnName("EMP_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__TBL_EMPL__16EBFA264CA62B2E");

                entity.ToTable("TBL_EMPLOYEES");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.EmpDob)
                    .HasColumnName("EMP_DOB")
                    .HasColumnType("datetime2(3)");

                entity.Property(e => e.EmpName)
                    .HasColumnName("EMP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary)
                    .HasColumnName("EMP_SALARY")
                    .HasColumnType("money");

                entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
