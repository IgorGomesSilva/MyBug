using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            
            BuscaAPI();
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
                _banco.Bugs.Update(bugSaved);

            }

            _banco.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task BuscaAPI()
         {
             using (HttpClient client = new HttpClient())
             {

                 client.BaseAddress = new Uri("https://dev.people.com.ai/bug/api/v3/products");
                 var resposta = await client.GetAsync("");

                 string dados = await resposta.Content.ReadAsStringAsync();
                Console.WriteLine(dados);
                                
             }
         }
    }

}