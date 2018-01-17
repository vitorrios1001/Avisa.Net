using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Avisa.Net.Models;

namespace Avisa.Net.Controllers
{
    public class MensagemController : Controller
    {
        

        public IActionResult ListaMensagens()
        {
            return View("ListaMensagens");
        }        
        
    }
}