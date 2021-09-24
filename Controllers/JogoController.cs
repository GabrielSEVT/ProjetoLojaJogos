using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;
using ProjetoLojaJogos.Repositorio;

namespace ProjetoLojaJogos.Controllers
{
    public class JogoController : Controller
    {
        public ActionResult Jogo()
        {
            var jogo = new Jogo();
            return View(jogo);
        }

        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Jogo(Jogo jogo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarJogo(jogo);
                    return RedirectToAction("JogosCadastrados");
                }

                return View(jogo);
            }
            catch
            {
                return View("JogosCadastrados");
            }
        }

        public ActionResult JogosCadastrados()
        {
            var exibirJogo = new Acoes();
            var todosJogos = exibirJogo.ListarJogo();
            return View(todosJogos);
        }
    }
}