
namespace EducCenter.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    public class Parent : IdentityUser
    {
        
        public int Id { get; set; } 

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Student> Students { get; set; } = new HashSet<Student>();
    }
}
