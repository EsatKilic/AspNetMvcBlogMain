using App.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PageController : Controller
    {
        private readonly AppDbContext _context;

        public PageController(AppDbContext context)
        {
            _context = context;
        }

        [Route("page/{slug}", Name = "Page")]
        public IActionResult Detail(int id)
        {
            //var pageName = _context.Pages.Where(e => e.Id == id).FirstOrDefault();
            //ViewBag.PageName = pageName.Title;
            return View();
        }


        public IActionResult Images()
        {
            return View();
        }
        public IActionResult Articles()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}