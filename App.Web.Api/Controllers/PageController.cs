using App.Business.Services;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly PageService _pageService;
        public PageController(PageService ps)
        {
            _pageService = ps;
        }

        // GET: api/<PageController>
        [HttpGet]
        public List<Data.Entity.Page> Get()
        {
            return _pageService.GetAll();
        }

        // GET api/<PageController>/5
        [HttpGet("{id}")]
        public Data.Entity.Page Get(int id)
        {
            return _pageService.GetById(id);
        }

        // POST api/<PageController>
        [HttpPost]
        public void Post([FromBody] Data.Entity.Page value)
        {
            _pageService.Insert(value);
        }

        // PUT api/<PageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Data.Entity.Page value)
        {
            _pageService.Update(value);
        }

        // DELETE api/<PageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pageService.DeleteById(id);
        }
    }
}
