﻿namespace PostagensAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public bool Ativo { get; set; }

    }
}
