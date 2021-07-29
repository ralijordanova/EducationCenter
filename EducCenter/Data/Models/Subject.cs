
namespace EducCenter.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Subject
    {
               
        public int Id { get; init; }

        [Required]
        [MaxLength(SubjectNameMaxLength)]
        public string Name { get; set; }


        [MaxLength(SubjectDescriptionMaxLength)]
        public string Description { get; set; }


        public ICollection<SubjectCourse> Courses { get; set; } = new HashSet<SubjectCourse>();

        
    }
}
