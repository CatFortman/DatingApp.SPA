using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    // http//localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            List<Models.Value> values = _context.Values.ToList();

            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            Models.Value value = _context.Values.FirstOrDefault(v => v.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost] public void Post([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut("{id}")] public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")] public void Delete(int id) { }
    }
}
