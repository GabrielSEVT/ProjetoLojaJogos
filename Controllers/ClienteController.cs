using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ViewBag.Message = "Cadastro de clientes";
            var cliente = new Cliente();
            return View();
        }

        [HttpPost]

        public ActionResult Index(Cliente cliente) 
        {
            if (ModelState.IsValid) 
            {
                return View("ResultCadCliente", cliente);
            }
            return View(cliente);
        }

        public ActionResult ResultCadCliente(Cliente cliente) 
        {
            return View(cliente);
        }
    }
}