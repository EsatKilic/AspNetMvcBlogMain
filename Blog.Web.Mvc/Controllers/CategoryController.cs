using Blog.Web.Mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Blog.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [Route("/category/{slug}", Name = "Category")]
        public IActionResult Index(string slug)
        {
            var categoryNames = _context.Categories.Include(e => e.Posts).ToList();
            ViewBag.CategoryNames = categoryNames;

            var posts = _context.Posts
                .Include(p => p.Categories)
                .Where(e => e.Categories.Any(e => e.Slug == slug))
                .ToList();

            var category = _context.Categories.Where(e => e.Slug == slug).FirstOrDefault();
            ViewBag.CategoryName = category.Name;

            return View(posts);
        }
    }
}
