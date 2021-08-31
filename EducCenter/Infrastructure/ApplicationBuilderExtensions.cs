
namespace EducCenter.Infrastructure
{
    using EducCenter.Data;
    using EducCenter.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var data = scopedServices.ServiceProvider.GetService<EducCenterDbContext>();
            data.Database.Migrate();

            SeedSubjects(data);

            return app;
        }
        private static void SeedSubjects(EducCenterDbContext data)
        {
            if (data.Subjects.Any())
            {
                return;
            }
            data.Subjects.AddRange(new[]
            {
                new Subject{ Name = "Mathematics"},
                new Subject{ Name = "Bulgarian"},
                new Subject{ Name = "English"},
                new Subject{ Name = "Russian"},
                new Subject{ Name = "Music"},
                new Subject{ Name = "Art"},
                new Subject{ Name = "Psychology"},
                new Subject{ Name = "Programming"},
                new Subject{ Name = "Physics"},
                new Subject{ Name = "Chemistry"},
                new Subject{ Name = "Spanish"},
                new Subject{ Name = "French"},
            });
            data.SaveChanges();
        }
        
    }
}
