
namespace EducCenter.Models.Courses
{
    using System;
    using System.Collections.Generic;
    using EducCenter.Data.Models;
    using System.ComponentModel.DataAnnotations;   
    using static Data.Models.DataConstants;

    public class AddCourseFormModel
    {
        [Required]
        [MinLength(CourseNameMinLength)]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; init; }

        [Required]
        public decimal Price { get; init; }

        [Required]
        [Display(Name = "Select Start Date")]
        [Range(CourseStartDateMinValue, CourseStartDateMaxValue, ErrorMessage = "Date is between 2000 and 2500")]
        public DateTime StartDate { get; init; }

        [Required]
        [Display(Name = "Select End Date")]
        [Range(2000, 2500, ErrorMessage = "Date is between 2000 and 2500")]
        public DateTime EndDate { get; init; }

        [Display(Name = "Subject")]
        public int SubjectId { get; init; }
        public IEnumerable<CourseSubjectViewModel> Subjects { get; set; }


        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        public ICollection<CourseTeacherViewModel> Teachers { get; set; }


        public ICollection<StudentCourse> Students { get; set; }
    }
}
