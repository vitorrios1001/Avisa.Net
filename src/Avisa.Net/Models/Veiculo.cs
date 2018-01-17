namespace Avisa.Net.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Cor { get; set; }

        public ModeloVeiculo ModeloVeiculo { get; set; }

    }
}