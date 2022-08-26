using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Models
{
    public class QuestionAnswer
    {
        public int QuestionAnswerId { get; set; }

        [Required]
        public string Question { get; set; }

        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
    }
}
