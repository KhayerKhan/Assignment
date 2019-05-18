using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final.Data.Entities
{
    public class CourseTopic
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        [StringLength(512, ErrorMessage = "Length cannot be more than 512")]
        public string Name { get; set; }
        [Required]

        public string Description { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}