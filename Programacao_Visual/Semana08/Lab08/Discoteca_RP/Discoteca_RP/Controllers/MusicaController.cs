using Discoteca_RP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Discoteca_RP.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index()
        {
            Musica musica = new Musica
            {
                Codigo = 1,
                Titulo = "The Jazz Piano",
                AnoEdicao = 2013,
                Executantes = new List<string> { "Bensound", "Bensound Jr.", "Granny Bensound" }
            };
            
            return View(musica);    
        }
    }
}
