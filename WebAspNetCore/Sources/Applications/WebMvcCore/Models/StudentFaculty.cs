﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcCore.Data;

namespace WebMvcCore.Models
{
    public class StudentFaculty
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
