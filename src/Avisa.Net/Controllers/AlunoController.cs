using Microsoft.AspNetCore.Mvc;

namespace Avisa.Net.Controllers
{
    public class AlunoController : Controller   
    {
        public IActionResult ListaAlunos()
        {
            return View("ListaAlunos");
        }
        
        
    }
}