using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Models;
public class RegisterViewModel
{
    [Display(Name = "�sim", Prompt = "�sim")]
    [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? SurName { get; set; }

    [Display(Name = "E-Mail", Prompt = "isim@�rnek.com")]
    [MaxLength(200, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? EmailAddress { get; set; }

    [Display(Name = "�ifre", Prompt = "�ifre")]
    [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? Password { get; set; }

    public string? Phone { get; set; }

}
