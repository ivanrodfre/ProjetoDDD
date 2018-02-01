using System;

namespace Domain.Entidades
{
    public class Cliente
    {
       

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Indade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
