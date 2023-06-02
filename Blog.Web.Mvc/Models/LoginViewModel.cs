using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models;
public class LoginViewModel
{

    [Display(Name = "E-Mail", Prompt = "isim@�rnek.com")]
    [Required(ErrorMessage = "{0} Gereklidir!")]
    public string? EmailAddress { get; set; }

    [Display(Name = "�ifre", Prompt = "�ifre")]
    [Required(ErrorMessage = "{0} Gereklidir!")]
    public string? Password { get; set; }

    public bool RememberMe { get; set; }
}