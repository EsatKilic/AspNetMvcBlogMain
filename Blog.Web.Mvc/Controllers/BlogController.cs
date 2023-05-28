using Blog.Web.Mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;

        public BlogController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Search(string query, int page = 1)
        {
            var posts = _db.Posts
                .Include(p => p.Categories)
                .Where(e => e.Title.Contains(query))
                .Skip((page - 1) * 10).Take(10)
                .ToList();

            ViewBag.Query = query;

            return View(posts);
        }

        [Route("blog/{slug}", Name = "Blog")]
        public IActionResult Detail(int id)
        {
            var categoryNames = _db.Categories.Include(e => e.Posts).ToList();
            ViewBag.CategoryNames = categoryNames;

            var post = _db.Posts
                .Include(e => e.Categories)
                .Include(e => e.PostImages)
                .Where(e => e.Id == id)
                .FirstOrDefault();

            ViewBag.PostComments = _db.PostComments
                .Include(e => e.User)
                .Where(e => e.PostId == id)
                .ToList();

            var userId = _db.Posts.Where(e => e.Id == id).FirstOrDefault().UserId;
            ViewBag.User = _db.Users.Where(e => e.Id == userId).FirstOrDefault();

            ViewBag.NextPost = _db.Posts.OrderBy(e => e.Id).Where(e => e.Id > id).FirstOrDefault();
            ViewBag.PreviousPost = _db.Posts.OrderBy(e => e.Id).Where(e => e.Id < id).LastOrDefault();

            return View(post);
        }
    }
}
