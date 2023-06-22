using App.Business.Services;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService cs)
        {
            _categoryService = cs;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category value)
        {
            _categoryService.Insert(value);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category value)
        {
            _categoryService.Update(value);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.DeleteById(id);
        }
    }
}
