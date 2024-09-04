using Microsoft.EntityFrameworkCore;
using PostagensAPI.Models;

namespace PostagensAPI.Db
{
    public class PostagemDbContext : DbContext 
    {
        public PostagemDbContext(DbContextOptions<PostagemDbContext>options ) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Tag> Tags { get; set; }    
    }
}
