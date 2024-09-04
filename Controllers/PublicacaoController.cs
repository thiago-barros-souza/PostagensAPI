using Microsoft.AspNetCore.Mvc;
using PostagensAPI.Db;
using PostagensAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostagensAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacaoController : ControllerBase
    {
        private readonly PostagemDbContext _context;

        public PublicacaoController(PostagemDbContext context)
        {
            _context = context;
        }
        // GET: api/<PublicacaoController>
        [HttpGet]
        public IEnumerable<Publicacao> Get()
        {
            var publicacoes = _context.Publicacoes.ToList();
            return publicacoes;
        }

        // GET api/<PublicacaoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PublicacaoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PublicacaoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PublicacaoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
