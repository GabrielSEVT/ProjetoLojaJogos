using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            ViewBag.Message = "Cadastro de jogos";
            var jogo = new Jogo();
            return View();
        }

        [HttpPost]

        public ActionResult Index(Jogo jogo) 
        {
            if (ModelState.IsValid) 
            {
                return View("ResultCadJogo", jogo);
            }
            return View(jogo);
        }

        public ActionResult ResultCadJogo(Jogo jogo) 
        {
            return View(jogo);
        }
    }
}