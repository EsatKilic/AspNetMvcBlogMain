using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Settings : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
