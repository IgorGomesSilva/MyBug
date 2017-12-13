using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myBug.Data;
using myBug.Models;

namespace myBug.Controllers
{
    public class HomeController : Controller
    {
        private readonly Banco _banco;

        public HomeController( Banco banco)
        {
            _banco = banco;

        }
        public IActionResult Index()
        {
            var bugs = _banco.Bugs.ToList();
            ViewBag.Bugs = bugs;

            return View();
        }

        public IActionResult Bug()
        {

            return View();
        }

        public IActionResult Admin()
        {
            
            return View();
        }

        public IActionResult Comentario()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
