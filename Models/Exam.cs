using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        [Required(ErrorMessage = "ExamName cannot be empty!")]
        public string ExamName { get; set; }

        [Required(ErrorMessage = "ExamDescription cannot be empty!")]
        public string ExamDescription { get; set; }

        #region Navigation Properties to the Book Model

                   // Suppress the information about the FK Collection to the API.
        public ICollection<Result> Result { get; set; }


        #endregion
    }
}
