using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirstApp.Models
{
    public partial class empDBContext : DbContext
    {
        public empDBContext()
        {

        }

        public empDBContext(DbContextOptions<empDBContext> options) : base(options)
        {

        }

        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        //public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=LAPTOP-EG6AFCLE\\SQLEXPRESS;database=TESTDB;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("EmployeeTABLE");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.EmpAdd)
                    .HasMaxLength(30)
                    .HasColumnName("empAdd");

                entity.Property(e => e.EmpAge).HasColumnName("empAge");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpSal)
                    .HasColumnType("money")
                    .HasColumnName("empSal");
            });

            //modelBuilder.Entity<Student>(entity =>
            //{
            //    entity.HasKey(e => e.StdId)
            //        .HasName("PK__Student__BA08FEBB3B4FDDE8");

            //    entity.ToTable("Student");

            //    entity.Property(e => e.StdId).HasColumnName("stdId");

            //    entity.Property(e => e.StdAge).HasColumnName("stdAge");

            //    entity.Property(e => e.StdName)
            //        .HasMaxLength(50)
            //        .HasColumnName("stdName");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        internal void Entry()
        {
            throw new NotImplementedException();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
