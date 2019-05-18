using System;
using System.Collections.Generic;
using System.Text;
using Final.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Final.Data
{
    public class StudentContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public StudentContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly(_migrationAssemblyName));
            }
        }



        public DbSet<Student> Students { get; set; }
       
        public DbSet<CourseTopic> CourseTopics { get; set; }

    }
}
