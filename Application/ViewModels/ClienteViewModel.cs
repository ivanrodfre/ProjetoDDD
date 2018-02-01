using System;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{

    public class ClienteViewModel
    {

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Indade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
