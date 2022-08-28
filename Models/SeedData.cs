using LMS.Web.Data;
using LMS.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LMS.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for an To-Do tasks
                if (context.Results.Any())
                {
                    return; // DB has been seeded
                }

                context.QuestionAnswer.AddRange(
                    new QuestionAnswer
                    {
                        Question="HTML Stands for",
                        Option1="Hyper text",
                        Option2="High text Language",
                        Option3="hyper text language",
                        Option4="Hyper Text Markup Language",
                        Answer="Hper Text Markup Language"
                    }
                    ); ;
                context.SaveChanges();
            }
        }
    }
}
