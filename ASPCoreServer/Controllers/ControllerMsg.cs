using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerMsg : ControllerBase
    {
        // GET api/<ControllerMsg>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Hi its me "+id.ToString();
        }

        // POST api/<ControllerMsg>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ControllerMsg>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControllerMsg>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
