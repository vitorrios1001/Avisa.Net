using System.Collections.Generic;

namespace AvisaNet.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            this.Veiculos = new List<Veiculo>();            
        }    

        public int Id { get; set; }

        public string Matricula { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Cnh { get; set; }

        public virtual IEnumerable<Veiculo> Veiculos { get; set; }

        //public TipoPessoa TipoPessoa { get; set; }   

        public int TipoPessoa_Id { get; set; }
        
    }
}