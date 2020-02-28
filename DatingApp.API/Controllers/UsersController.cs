using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly IDatingRepository _repo;

        public UsersController(IDatingRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            IEnumerable<User> users = await _repo.GetUsers();

            return Ok(users);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            User user = await _repo.GetUser(id);

            return Ok(user);
        }
    }
}