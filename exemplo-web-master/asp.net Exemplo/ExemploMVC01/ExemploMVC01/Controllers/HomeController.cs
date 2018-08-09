using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //logica pro usuario usar o sistema
            ViewBag.Nome = "Stolfado";
            ViewBag.Idade = 16;
            return View();
            // view fica os htmls
        }
        public ActionResult Calculadora()
        {
            return View();
        }
        public ActionResult Calcular(int numero01, int numero02)
        {
            int soma = numero01 + numero02;
            ViewBag.Soma = soma;
            ViewBag.Numero1 = numero01;
            ViewBag.Numero2 = numero02;
            return View();
        }
    }
}