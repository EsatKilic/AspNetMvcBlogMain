using Blog.Web.Mvc.Data.Entity;

namespace Blog.Web.Mvc.Models;

public class NavbarViewModel
{
    public List<Category> Categories { get; set; }
    public List<Page> Pages { get; set; }
}