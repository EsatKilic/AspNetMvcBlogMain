using App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.Components;

public class ArticleViewComponent : ViewComponent
{
    private readonly AppDbContext _db;

    public ArticleViewComponent(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var posts = _db.Posts
            .Include(e => e.Categories)
            .Where(e => e.IsFeatured).ToList();

        return View(posts);
    }
}
