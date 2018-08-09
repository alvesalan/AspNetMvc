using ExercicioAlunos.Models;
using ExercicioAlunos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioAlunos.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            List<Aluno> alunos = new AlunoRepositorio().ObterTodos();
            ViewBag.Alunos = alunos;
            ViewBag.TituloPagina = "Alunos";
            return View();
        }

        [HttpPost]
        public ActionResult Store(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                int cod = new AlunoRepositorio().Cadastrar(aluno);
                 return RedirectToAction("Index");
                
            }

            ViewBag.Aluno = aluno;
            return View("Cadastro");

        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new AlunoRepositorio().Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Cadastro";
            ViewBag.Aluno = new Aluno();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
           Aluno aluno = new AlunoRepositorio().ObterPeloId(id);
            ViewBag.Aluno = aluno;
            return View();
        }


        [HttpPost]
        public ActionResult Update(Aluno aluno)
        {
            bool alterado = new AlunoRepositorio().Alterar(aluno);
            return RedirectToAction("Index");
        }
    }
}