using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Models;

public class ForgotPasswordViewModel
{
    [EmailAddress]
    public string? EmailAddress { get; set; }
}