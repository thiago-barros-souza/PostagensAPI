namespace PostagensAPI.Models
{
    public class Publicacao
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Conteudo { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        // Relacionamento com Categoria
        public int CategoriaId { get; set; }
        public int TagId { get; set; }
    }
}
