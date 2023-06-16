using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Models;
public class LoginViewModel
{

    [Display(Name = "E-Mail", Prompt = "isim@örnek.com")]
    [Required(ErrorMessage = "{0} Gereklidir!")]
    public string? EmailAddress { get; set; }

    [Display(Name = "Þifre", Prompt = "Þifre")]
    [Required(ErrorMessage = "{0} Gereklidir!")]
    public string? Password { get; set; }

    public bool RememberMe { get; set; }
}