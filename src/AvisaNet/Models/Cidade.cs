namespace AvisaNet.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public UF UF { get; set; }

        public int UF_Id { get; set; }
        
    }
}