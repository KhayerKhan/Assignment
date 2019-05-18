using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMvcCore.Models;

namespace WebMvcCore.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Adding Relation Using (Fluent API)
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Faculty>().ToTable("Faculty");
            modelBuilder.Entity<StudentFaculty>().ToTable("StudentFaculty");

            modelBuilder.Entity<StudentFaculty>()
                .HasKey(x => new {x.StudentId, x.FacultyId});
            modelBuilder.Entity<StudentFaculty>()
                .HasOne(x => x.Student)
                .WithMany(x => x.StudentFaculties)
                .HasForeignKey(x => x.StudentId);
            modelBuilder.Entity<StudentFaculty>()
                .HasOne(x => x.Faculty)
                .WithMany(x => x.StudentFaculties)
                .HasForeignKey(x => x.FacultyId);
            #endregion

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public StudentFaculty StudentFaculty { get; set; }

    }
}
