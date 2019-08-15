using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWebApiTest.Models
{
    public partial class TaxProductContext : DbContext
    {
        public TaxProductContext()
        {
        }

        public TaxProductContext(DbContextOptions<TaxProductContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblSkills> TblSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__tblEmplo__7AD04FF196D8C101");

                entity.ToTable("tblEmployees");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillId).HasColumnName("SkillID");
            });

            modelBuilder.Entity<TblSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__tblSkill__DFA091E77DA76FA7");

                entity.ToTable("tblSkills");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
