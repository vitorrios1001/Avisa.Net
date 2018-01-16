namespace Avisa.Net.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public Modelo Modelo { get; set; }
        
    }
}