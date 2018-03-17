using Avisa.Net.Models;

namespace AvisaNet.Models
{
    public class Ocorrencia
    {
        public int Id { get; set; }

        public int Mensagem_Id { get; set; }    

        public virtual Mensagem Mensagem { get; set; }  

       // public string Imagem { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public int Pessoa_Id { get; set; }

        public virtual Veiculo Veiculo { get; set; } 

        public int Veiculo_Id { get; set; }   

    //    public virtual Usuario Usuario { get; set; }

    //    public int Usuario_Id { get; set; }
    
    }
}