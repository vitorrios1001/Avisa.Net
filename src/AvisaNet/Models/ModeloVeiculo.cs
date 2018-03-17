namespace AvisaNet.Models
{
    public class ModeloVeiculo
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public virtual MarcaVeiculo MarcaVeiculo { get; set; }

        public int MarcaVeiculo_Id { get; set; }

//        public TipoVeiculo TipoVeiculo { get; set; }

//        public int TipoVeiculo_Id { get; set; }
    }
}