namespace AvisaNet.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public int Pessoa_id { get; set; }

       // public string Cor { get; set; }

        public string Placa { get; set; }

        public string CaracteristicasExtra { get; set; }

        public virtual ModeloVeiculo ModeloVeiculo { get; set; }

        public int ModeloVeiculo_Id { get; set; }
        
    }
}