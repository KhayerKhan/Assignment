using System;
using System.Collections.Generic;
using System.Text;
using Final.Data.Entities;
using Final.Repository;


namespace Final.Data
{
    public class StudentRepository : Repository<Student>
    {
        public StudentRepository(StudentContext context) : base(context)
        {
            
        }

       
    }
}
