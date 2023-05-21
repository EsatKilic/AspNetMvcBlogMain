﻿using Blog.Web.Mvc.Data;
using Blog.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Mvc.Components;

public class NavbarViewComponent : ViewComponent
{
    private AppDbContext db { get; set; }

    public NavbarViewComponent(AppDbContext db)
    {
        this.db = db;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var vm = new NavbarViewModel
        {
            Categories = db.Categories.ToList(),
            Pages = db.Pages.ToList(),
        };

        return View(vm);
    }
}