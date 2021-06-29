using Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            this._clienteServico = clienteServico;
        }

        public ActionResult Index()
        {
            var clientes = _clienteServico.SelecionarClientes();
            var viewModel = clientes?.Select(x => new ClienteViewModel(x)).ToList();
            return View(viewModel);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(ClienteViewModel clienteViewModel)
        {
            var cliente = clienteViewModel.SetCliente();
            _clienteServico.InserirCliente(cliente);
            clienteViewModel.Id = cliente.Id;
            return View(clienteViewModel);
        }
    }
}