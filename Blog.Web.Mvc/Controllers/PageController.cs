using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Controllers
{
    public class PageController : Controller
    {
        [Route("page/{slug}", Name = "Page")]
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}