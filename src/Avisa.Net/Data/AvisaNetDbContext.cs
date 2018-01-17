using Avisa.Net.Models;
using Microsoft.EntityFrameworkCore;
using Avisa.Net.Data.EntityConfiguration;

namespace Avisa.Net.Data
{
    public class AvisaNetDbContext : DbContext
    {
        public AvisaNetDbContext(DbContextOptions<AvisaNetDbContext> options) : base (options)
        {             
        }

        #region DbSet

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<Mensagem> Mensagem { get; set; }

        public DbSet<MarcaVeiculo> MarcaVeiculo { get; set; }

        public DbSet<ModeloVeiculo> ModeloVeiculo { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }
        
        #endregion        
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                        

            modelBuilder.Entity<AvisaNetDbContext>().ToTable("db_AvisaNet");

            base.OnModelCreating(modelBuilder);
        }

        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
       
    }
}