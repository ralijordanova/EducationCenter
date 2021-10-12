
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Course
    {
              
        public int Id { get; init; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<SubjectCourse> Subjects { get; set; } = new HashSet<SubjectCourse>();

        public ICollection<TeacherCourse> Teachers { get; set; } = new HashSet<TeacherCourse>();

        public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
        
    }
}
