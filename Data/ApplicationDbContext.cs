// NOTES:
//      Please add the following NuGet packages:
//      (a) Microsoft.EntityFrameworkCore (ver 3.x)
//      (b) Microsoft.EntityFrameworkCore.SqlServer (ver 3.x)
//      (c) Microsoft.EntityFrameworkCore.Tools (ver 3.x)  -- for EF Core Data Migrations
//      Make sure all the three Nuget packages for EF Core have the same version!!!!

using LMS.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public DbSet<Result> Results { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }


    }
}
