using Avisa.Net.Data;

namespace AvisaNet.Data
{
    public class InitDb
    {
        public static void Init(AvisaNetDbContext avisaNetDbContext)
        {
            avisaNetDbContext.Database.EnsureCreated();

            avisaNetDbContext.SaveChanges();
        }
    }
}