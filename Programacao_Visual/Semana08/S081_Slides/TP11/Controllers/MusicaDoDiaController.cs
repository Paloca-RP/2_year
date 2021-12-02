using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP11.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TP11.Controllers
{
    public class MusicaDoDiaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Foto f = new Foto() { Codigo = "ABC000001", Titulo = "Deserto" };
            return View(f);
        }
    }
}
