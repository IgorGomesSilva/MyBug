using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myBug.Data;
using myBug.Models;

namespace myBug.Controllers
{
    public class BugController : Controller
    {
        private readonly Banco _banco;

        public BugController(Banco banco)
        {
            _banco = banco;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Bug bug)
        {
            _banco.Bugs.Add(bug);
            _banco.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}