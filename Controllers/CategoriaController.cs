using Microsoft.AspNetCore.Mvc;
using PostagensAPI.Db;
using PostagensAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostagensAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly PostagemDbContext _context;

        public CategoriaController(PostagemDbContext context)
        {
            _context = context;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            var categorias = _context.Categorias.ToList();
            return categorias;
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
