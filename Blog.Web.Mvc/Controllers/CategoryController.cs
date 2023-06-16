using App.Data;
using App.Data.Entity;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Umbraco.Core.Models.Membership;
using Umbraco.Core.Services.Implement;


namespace App.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        //private readonly CategoryService _cs;
        //private readonly PostService _ps;

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
