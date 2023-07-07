using App.Business.Services.Abstract;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using App.Business.Services.Abstract;
using App.Business.Services;

namespace Blog.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService cs)
        {
            _categoryService = cs;
        }

        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
        }

        public IActionResult Details(int id)
        {

            return View(_categoryService.GetById(id));
        }
        public IActionResult Edit(int id)
        {
            return View(_categoryService.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Category c)
        {
            _categoryService.Update(c);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {
            return View(_categoryService.GetById(id));

        }
        [HttpPost]
        public IActionResult Delete(Category c)
        {
            _categoryService.DeleteById(c.Id);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Category c)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Insert(c);

                return RedirectToAction(nameof(Index));
            }
            return View(c);
        }
    }
}
