using ExercicioMecanica.Models;
using ExercicioMecanica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioMecanica.Controllers
{
    public class MecanicaController : Controller
    {
        // GET: Mecanica

        [HttpGet]
        public ActionResult Index()
        {
            List<Servico> servicos = new ServicoRepositorio().ObterTodos();
            ViewBag.Servico = servicos;
            ViewBag.Titulo = "Servicos";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.Servico = new Servico();
            return View();
        }

        [HttpPost]
        public ActionResult Store(Servico servico)
        {
            int COD = new ServicoRepositorio().Cadastrar(servico);
            ViewBag.Servico = servico;
            return View("Cadastro");
        }
    }
}