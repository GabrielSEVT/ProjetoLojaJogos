using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;
using ProjetoLojaJogos.Repositorio;

namespace ProjetoLojaJogos.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Cliente()
        {
            ViewBag.Message = "Cadastro de funcionários";
            var cliente = new Cliente();
            return View(cliente);
        }

        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Cliente(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarCliente(cliente);
                    return RedirectToAction("ClientesCadastrados");
                }

                return View(cliente);
            }
            catch
            {
                return View("ClientesCadastrados");
            }
        }

        public ActionResult ClientesCadastrados()
        {
            var mostrarCliente = new Acoes();
            var todosClientes = mostrarCliente.ListarCliente();
            return View(todosClientes);
        }
    }
}