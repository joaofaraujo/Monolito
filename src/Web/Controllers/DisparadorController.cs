using Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/disparador")]
    public class DisparadorController : Controller
    {
        private readonly IDisparadorServico _disparadorServico;

        public DisparadorController(IDisparadorServico disparadorServico)
        {
            this._disparadorServico = disparadorServico;
        }

        [HttpPost]
        public JsonResult Post(DisparadorViewModel disparadorViewModel)
        {
            disparadorViewModel.IdDisparo = _disparadorServico.RealizarDisparoCliente(disparadorViewModel.IdCliente, disparadorViewModel.Mensagem, disparadorViewModel.Canal);
            Response.StatusCode = 200;
            return Json(disparadorViewModel);
        }
    }
}