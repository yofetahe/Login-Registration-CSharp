using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LogUser
    {
       [Display(Name="Email")]
       [Required(ErrorMessage="Email is required.")]
       [EmailAddress]
       public string Email { get; set; }
       
       [Display(Name="Password")]
       [Required(ErrorMessage="Password is required.")]
       [MinLength(8, ErrorMessage="Min of 8 character")]
       [DataType(DataType.Password)]
       public string Password { get; set; }
    }
}