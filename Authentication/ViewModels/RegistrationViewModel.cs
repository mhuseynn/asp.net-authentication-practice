using System.ComponentModel.DataAnnotations;

namespace Authentication.ViewModels;

public class RegistrationViewModel
{
    
    [MinLength(3,ErrorMessage ="Olcusu 3 den boyuk olmalidir")]
    [Required]
    public string Name { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Required]
    [Display(Name = "Confirm password")]
    [Compare("Password",ErrorMessage ="Eshleshmedi")]
    public string RePassword { get; set; }


}
