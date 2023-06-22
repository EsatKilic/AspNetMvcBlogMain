using App.Business.Services;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostService _postService;

        public PostController(PostService ps)
        {
            _postService = ps;
        }

        // GET: api/<PostController>
        [HttpGet]
        public List<Post> Get()
        {
            return _postService.GetAll(); 
        }

        // GET api/<PostController>/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postService.GetById(id);
        }

        // POST api/<PostController>
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            _postService.Insert(post);
        }

        // PUT api/<PostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post value)
        {
            _postService.Update(value);
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postService.DeleteById(id);
        }
    }
}
