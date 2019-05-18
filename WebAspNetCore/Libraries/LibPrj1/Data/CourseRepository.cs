using Final.Data.Entities;
using Final.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Data
{
   public class CourseRepository : Repository<Course>
    {
        public CourseRepository(StudentContext context) : base(context)
        {

        }
    }
}
