using System.ComponentModel.DataAnnotations;

namespace App.Web.Mvc.Models;

public class ForgotPasswordViewModel
{
    [EmailAddress]
    public string? EmailAddress { get; set; }
}