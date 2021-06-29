using Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/tracking")]
    public class TrackingController : Controller
    {
        private readonly ITrackingServico _trackingServico;

        public TrackingController(ITrackingServico trackingServico)
        {
            this._trackingServico = trackingServico;
        }

        [HttpGet]
        [Route("api/tracking/disparo/{disparo}")]
        public JsonResult GetDisparo(Guid disparo)
        {
            var tracking = _trackingServico.SelecionarTrackingPorDisparo(disparo);
            var trackingViewModel = tracking?.Select(x => new TrackingViewModel(x)).ToList();
            Response.StatusCode = 200;
            return Json(trackingViewModel, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("api/tracking/cliente/{idCliente}")]
        public JsonResult GetCliente(long idCliente)
        {
            var tracking = _trackingServico.SelecionarTrackingPorCliente(idCliente);
            var trackingViewModel = tracking?.Select(x => new TrackingViewModel(x)).ToList();
            Response.StatusCode = 200;
            return Json(trackingViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}