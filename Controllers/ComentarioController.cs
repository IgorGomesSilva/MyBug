using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using myBug.Data;
using myBug.Models;

namespace myBug.Controllers
{
    public class ComentarioController : Controller
    {

        private readonly Banco _banco;

        public ComentarioController(Banco banco)
        {
            _banco = banco;
            
        }
        public IActionResult Index()
        {
            ViewBag.Comentario = new SelectList(_banco.Bugs, "Id", "Titulo");

            return View();
        }

        public IActionResult Comentar(Comentario com)
        {
               
            _banco.Comentarios.Add(com);
            _banco.SaveChanges();
            

            return View("Index");
        }
    }
}