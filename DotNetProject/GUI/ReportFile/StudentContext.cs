using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=StudentContext")
        {
        }

        public virtual DbSet<COURSE> COURSEs { get; set; }
        public virtual DbSet<GRADELIST> GRADELISTs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<SUBJECTT> SUBJECTTs { get; set; }
        public virtual DbSet<TEACHER> TEACHERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COURSE>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COURSE>()
                .Property(e => e.HOMEROOMTEACHERID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.MATH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.LITERATURE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.ENGLISH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.PHYSICAL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.CHEMISTRY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.HISTORY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.GEOGRAPHYY)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GRADELIST>()
                .Property(e => e.AVGGRADE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.COURSEID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .HasOptional(e => e.GRADELIST)
                .WithRequired(e => e.STUDENT);

            modelBuilder.Entity<SUBJECTT>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECTT>()
                .HasMany(e => e.TEACHERs)
                .WithOptional(e => e.SUBJECTT)
                .HasForeignKey(e => e.SUBJECTID);

            modelBuilder.Entity<TEACHER>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TEACHER>()
                .Property(e => e.SUBJECTID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TEACHER>()
                .HasMany(e => e.COURSEs)
                .WithOptional(e => e.TEACHER)
                .HasForeignKey(e => e.HOMEROOMTEACHERID);
        }
    }
}
