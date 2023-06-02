using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models;
public class RegisterViewModel
{
    [Display(Name = "Ýsim", Prompt = "Ýsim")]
    [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? SurName { get; set; }

    [Display(Name = "E-Mail", Prompt = "isim@örnek.com")]
    [MaxLength(200, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? EmailAddress { get; set; }

    [Display(Name = "Þifre", Prompt = "Þifre")]
    [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
    public string? Password { get; set; }

    public string? Phone { get; set; }

}
