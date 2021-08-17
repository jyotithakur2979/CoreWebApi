using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreWebApi.Entity
{
    public partial class jyotiContext : DbContext
    {
        public jyotiContext()
        {
        }

        public jyotiContext(DbContextOptions<jyotiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClassDetail> ClassDetails { get; set; }
        public virtual DbSet<Clg> Clgs { get; set; }
        public virtual DbSet<CountryName> CountryNames { get; set; }
        public virtual DbSet<EmployeDatum> EmployeData { get; set; }
        public virtual DbSet<PeriodDetail> PeriodDetails { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<ReportCard> ReportCards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<UserMst> UserMsts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SUDHIR\\SQLEXPRESS;Database=jyoti;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Topic).HasColumnName("topic");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ClassDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Rollno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rollno");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<Clg>(entity =>
            {
                entity.ToTable("Clg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileno");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CountryName>(entity =>
            {
                entity.ToTable("CountryName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Countryname1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("countryname");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<EmployeDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyname");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emailid");

                entity.Property(e => e.Employename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileno");
            });

            modelBuilder.Entity<PeriodDetail>(entity =>
            {
                entity.Property(e => e.PeriodDate).HasColumnType("date");

                entity.Property(e => e.PeriodForClass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PeriodDetails)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PeriodDetails_Teacher");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emailid");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileno");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ReportCard>(entity =>
            {
                entity.ToTable("ReportCard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chy).HasColumnName("chy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.Eng).HasColumnName("eng");

                entity.Property(e => e.Hindi).HasColumnName("hindi");

                entity.Property(e => e.Maths).HasColumnName("maths");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phs).HasColumnName("phs");

                entity.Property(e => e.RollNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("rollNo");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileno");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMst>(entity =>
            {
                entity.ToTable("UserMst");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
