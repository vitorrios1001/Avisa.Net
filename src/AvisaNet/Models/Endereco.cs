namespace AvisaNet.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public Cidade Cidade { get; set; }

        public int Cidade_Id { get; set; }

        public UF UF { get; set; }

        public int UF_Id { get; set; }

        public Pessoa Pessoa { get; set; }

        public int Pessoa_Id { get; set; }
        
    }
}