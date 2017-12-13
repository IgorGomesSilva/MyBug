using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using myBug.Data;
using myBug.Models;

using Newtonsoft.Json;

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
                bugSaved.Status = bug.Status;
                _banco.Bugs.Update(bugSaved);

            }

            _banco.SaveChanges();

            return RedirectToAction("../Home/Index");
        }


    }
}