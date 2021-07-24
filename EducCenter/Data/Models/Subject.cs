
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
               
        public int Id { get; set; }

        [Required]
        [MaxLength(SubjectNameMaxLength)]
        public string Name { get; set; }


        [MaxLength(SubjectDescriptionMaxLength)]
        public string Description { get; set; }



        //public int TeacherId { get; set; }
        //public virtual Teacher Teacher { get; set; }

        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

    }
}
