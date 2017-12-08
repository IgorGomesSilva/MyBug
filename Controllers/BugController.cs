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

        public IActionResult Index(int id)
        {
            var bugSelected = _banco.Bugs.FirstOrDefault(x => x.Id == id);


            return View(bugSelected);
        }

        [HttpPost]
        public IActionResult Cadastrar(Bug bug)
        {
            if(bug.Id == 0)
            {
                _banco.Bugs.Add(bug);
            }
            else
            {
                var bugSaved = _banco.Bugs.FirstOrDefault(x => x.Id == bug.Id);
                bugSaved.Titulo = bug.Titulo;
                bugSaved.Severidade = bug.Severidade;
                bugSaved.Descricao = bug.Email;
                bugSaved.DataRegistro = bug.DataRegistro;
                bugSaved.Email = bug.Email;
                bugSaved.Produto = bug.Produto;
                _banco.Bugs.Update(bugSaved);

            }

            _banco.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}