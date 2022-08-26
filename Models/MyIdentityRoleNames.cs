using System.ComponentModel.DataAnnotations;

namespace LMS.Web.Models
{
    public enum MyIdentityRoleNames
    {

        [Display(Name = "Admin Role")]
        AppAdmin,

        [Display(Name = "Librarian")]
        AppLibrarian,
        
        [Display(Name = "User Role")]
        AppUser

    }
}
