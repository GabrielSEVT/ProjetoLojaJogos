using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            ViewBag.Message = "Cadastro de funcionários";
            var funcionario = new Funcionario();
            return View();
        }

        [HttpPost]

        public ActionResult Index(Funcionario funcionario)
        {
            if (ModelState.IsValid) 
            {
                return View("ResultCadFuncionario", funcionario);
            }
            return View(funcionario);
        }

        public ActionResult ResultCadFuncionario(Funcionario funcionario) 
        {
            return View(funcionario);
        }
    }
}