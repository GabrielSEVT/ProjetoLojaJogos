using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;
using ProjetoLojaJogos.Repositorio;

namespace ProjetoLojaJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        public ActionResult Funcionario() 
        {
            ViewBag.Message = "Cadastro de funcionários";
            var funcionario = new Funcionario();
            return View(funcionario);

        }

        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Funcionario(Funcionario funcionario) 
        {
            try 
            {
                if (ModelState.IsValid) 
                {
                    ac.CadastrarFuncionario(funcionario);
                    return RedirectToAction("FuncionariosCadastrados");
                }
                return View(funcionario);
            }

            catch
            {
                return View("FuncionariosCadastrados");
            }
        }

        public ActionResult FuncionariosCadastrados() 
        {
            var exibirFuncionario = new Acoes();
            var todosFuncionarios = exibirFuncionario.ListarFuncionario();
            return View(todosFuncionarios);
        }
    }
}