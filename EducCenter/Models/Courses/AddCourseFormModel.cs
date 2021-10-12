
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
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength
            , ErrorMessage = "The course {0}-lendth max: {1}, min: {2}")]
        public string Name { get; init; }

        [Required]
        [Range(0, 10000)]
        public decimal Price { get; init; }

        [Required]
        [Display(Name = "Select Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; init; }

        [Required]
        [Display(Name = "Select End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; init; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; init; }

        [Required]
        [StringLength(CourseDescriptionMaxLength, 
            MinimumLength = CourseDescriptionMinLength, 
            ErrorMessage = "The course descr {0} max: {1}, min: {2}")]
        public string Description { get; init; }


        [Required]
        [Display(Name = "Subject")]
        public string[] SubjectId1ToMany { get; init; }
        public IEnumerable<CourseSubjectViewModel> Subjects { get; set; }

    }
}
