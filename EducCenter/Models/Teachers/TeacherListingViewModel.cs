namespace EducCenter.Models.Teachers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TeacherListingViewModel
    {
        public int Id { get; init; }     
        public string Name { get; init; }
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }

    }
}
