using System;
using System.Collections.Generic;
using System.Text;
using Final.Data;

using Microsoft.EntityFrameworkCore;

namespace Final.Data
{
    public class StudentUnitOfWork : UnitOfWork<StudentContext>
    {
        public StudentRepository Student { get; protected set; }
        public object Course { get; internal set; }

        public StudentUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            Student = new StudentRepository((StudentContext)DbContext);
        }
    }
}
