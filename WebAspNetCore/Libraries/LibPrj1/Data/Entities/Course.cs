using Final.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final.Data.Entities
{
    public class Course
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        [StringLength(512, ErrorMessage = "Length cannot be more than 512")]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }

        [Required]
        public string StartDate { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<CourseTopic> CourseTopics { get; set; }
     
    }
}