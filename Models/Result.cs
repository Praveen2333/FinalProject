using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Web.Models
{
    public class Result
    {
        public int ResultId { get; set; }

        [ForeignKey(nameof(Exam.ExamName))]
        public string ExamName { get; set; }

        public int Marks { get; set; }

    }
}
