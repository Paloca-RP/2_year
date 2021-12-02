using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP11.Models;

namespace TP11.Controllers
{
    public class FotoController : Controller
    {
        public IActionResult Index()
        {
            Foto f = new Foto() { Codigo = "ABC000001", Titulo = "Deserto" };
            return View(f);
        }
    }
}