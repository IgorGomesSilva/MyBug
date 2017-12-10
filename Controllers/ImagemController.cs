using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myBug.Data;
using myBug.Models;

namespace myBug.Controllers
{
    public class ImagemController : Controller
    {
        private readonly IHostingEnvironment hosting;

        private readonly Banco _banco;


        public ImagemController(IHostingEnvironment h, Banco banco)
        {
            hosting = h;
            _banco = banco;
        }

        public IActionResult Index()
        {

           var all = _banco.Imagens.ToList();

            ViewBag.Imagens = all;

            return View();
        }

        public IActionResult Upload(IFormFile myImagem, Imagem img)
        {
            if (myImagem != null)
            {
                var fileName = Path.Combine(hosting.WebRootPath, Path.GetFileName(myImagem.FileName));
                img.ImgCaminho = fileName;
                myImagem.CopyTo(new FileStream(fileName, FileMode.Create));
                ViewBag.Imagens = "/" + Path.GetFileName(myImagem.FileName);
                img.ImagName = ViewBag.Imagens;
                _banco.Imagens.Add(img);
                _banco.SaveChanges();

            }

            return RedirectToAction("Index");
        }


    }
}