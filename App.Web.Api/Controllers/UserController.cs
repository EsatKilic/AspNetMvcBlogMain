using App.Business.Services;
using App.Business.Services.Abstract;
using App.Data.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService us)
        {
            _userService = us;
        }

        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            _userService.Update(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteById(id);
        }
    }
}
