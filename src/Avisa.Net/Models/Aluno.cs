using System.Collections.Generic;

namespace Avisa.Net.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Matricula { get; set; }

        public string Nome { get; set; }    
      
        public string Telefone { get; set; }

        public string Email { get; set; }

        public IEnumerable<Veiculo> Veiculo { get; set; }        

    }
}