using DapperUseONapi.Interface;
using DapperUseONapi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperUseONapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IDapperService _service;
        public ToDoController(IDapperService service)
        {
            _service = service;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public Task<List<ToDo>> Get()
        {
            var tasks = _service.GetAll();
            return tasks;
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
