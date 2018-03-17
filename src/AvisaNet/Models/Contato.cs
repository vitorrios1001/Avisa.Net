namespace AvisaNet.Models
{
    public class Contato
    {
        public int Id { get; set; } 

        public Pessoa Pessoa { get; set; }  

        public int Pessoa_Id { get; set; }

        public string Tel1 { get; set; }    

        public string Tel2 { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        
    }
}