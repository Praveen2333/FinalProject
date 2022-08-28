using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Models
{
    public class QuestionAnswer
    {
        public int QuestionAnswerId { get; set; }

        [Required(ErrorMessage = "Question cannot be empty!")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Option1 cannot be empty!")]
        public string Option1 { get; set; }
        [Required(ErrorMessage = "Option2 cannot be empty!")]
        public string Option2 { get; set; }
        [Required(ErrorMessage = "Option3 cannot be empty!")]
        public string Option3 { get; set; }
        [Required(ErrorMessage = "Option4 cannot be empty!")]
        public string Option4 { get; set; }
        [Required(ErrorMessage = "Answer cannot be empty!")]
        public string Answer { get; set; }
    }
}
