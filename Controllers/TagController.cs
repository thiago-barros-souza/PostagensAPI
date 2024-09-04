using Microsoft.AspNetCore.Mvc;
using PostagensAPI.Db;
using PostagensAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostagensAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly PostagemDbContext _context;

        public TagController(PostagemDbContext context)
        {
            _context = context;
        }
        // GET: api/<TagController>
        [HttpGet]
        public IEnumerable<Tag> Get()
        {
            var tags = _context.Tags.ToList();
            return tags;
        }

        // GET api/<TagController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TagController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TagController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
