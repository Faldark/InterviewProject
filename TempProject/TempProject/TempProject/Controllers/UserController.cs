using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempProject.BLL.Abstract;
using TempProject.BLL.Services;
using TempProject.Data.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TempProject.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {

            return await _service.GetUserByIdAsync(id);
        }

        // POST api/values
        //Create User
        [HttpPost]
        public async Task<UserDTO> Post([FromBody]UserDTO user)
        {
            return await _service.CreateUserAsync(user);
        }

        // PUT api/values/5
        //Update USer
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]UserDTO user)
        {
            await _service.UpdateUserAsync(user);
        }

        // DELETE api/values/5
        //Delete User
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.RemoveUserAsync(id);
        }
    }
}
