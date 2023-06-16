using App.Data.Entity;

namespace App.Web.Mvc.Models;

public class NavbarViewModel
{
    public List<Category> Categories { get; set; }
    public List<Page> Pages { get; set; }
}