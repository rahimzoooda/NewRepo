using Microsoft.AspNetCore.Mvc;
using MyMessanger;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerMsg : ControllerBase
    {
        static List<Message> ListOfMessages = new List<Message>();
        // GET api/<ControllerMsg>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not Found ...";
            if ((id < ListOfMessages.Count) && (id>=0)) 
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщений № {0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST api/<ControllerMsg>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessages.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщений: {1}", ListOfMessages.Count, msg));
            return new OkResult();
        }
    }
}
