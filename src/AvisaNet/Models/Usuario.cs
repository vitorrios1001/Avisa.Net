namespace AvisaNet.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }    

        public int TipoUsuario_Id { get; set; } 

        public virtual Pessoa Pessoa { get; set; }  

        public int Pessoa_Id { get; set; }
    }
}