
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Data.Entities
{
    public class Student
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        [StringLength(512, ErrorMessage = "Length cannot be more than 512")]
        public string Name { get; set; }
          

        public ICollection<Course> courses { get; set; }
    }
}
