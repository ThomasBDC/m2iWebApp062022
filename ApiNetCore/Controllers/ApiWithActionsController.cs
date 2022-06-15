using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiWithActionsController : ControllerBase
    {
        // GET: api/<ApiWithActionsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ApiWithActionsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiWithActionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiWithActionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiWithActionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
