using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebMvcCore.Models;

namespace WebMvcCore.Models
{
    public class Student
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        [StringLength(512,ErrorMessage = "Length cannot be more than 512")]
        public string Name { get; set; }
        [Required]
        [StringLength(512)]
        public string Department { get; set; }
        [Required]
        [StringLength(512)]
        public string Email { get; set; }
        [StringLength(512)]
        public string Address { get; set; }

        public ICollection<StudentFaculty> StudentFaculties { get; set; }
        
    }
}