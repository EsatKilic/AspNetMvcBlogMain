using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Blog.Web.Mvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace Blog.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [Route("/category/{slug}", Name = "CategorySlug")]
        public IActionResult Index(string slug)
        {
            var posts = _context.Posts
                .Include(p => p.Category)
                .Where(e=>e.Category.Slug == slug)
                .ToList();

            var category = _context.Categories.Where(e => e.Slug == slug).FirstOrDefault();
            ViewBag.CategoryName = category.Name;

            return View(posts);
            
		}
    }
}
