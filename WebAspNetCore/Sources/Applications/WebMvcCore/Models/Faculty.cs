using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMvcCore.Data;

namespace WebMvcCore.Models
{
    public class Faculty
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        [StringLength(512,ErrorMessage = "String Len 512")]
        public string Name { get; set; }
        [Required]
        [StringLength(512)]
        public string Title { get; set; }
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
