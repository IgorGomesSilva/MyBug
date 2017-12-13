using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myBug.Data;

namespace myBug.Controllers
{
    public class AdminController : Controller
    {
        private readonly Banco _banco;

        public AdminController(Banco banco)
        {
            _banco = banco;
        }

        public IActionResult Index()
        {
            var bugs = _banco.Bugs.ToList();
            ViewBag.Bugs = bugs;

            return View();
        }

        public IActionResult Delete(int id)
        {
            var bugSelected = _banco.Bugs.FirstOrDefault(x => x.Id == id);
            _banco.Bugs.Remove(bugSelected);
            _banco.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}