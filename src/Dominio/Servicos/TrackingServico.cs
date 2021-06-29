using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Servicos
{
    public class TrackingServico : ITrackingServico
    {
        private readonly IRepositorio<Tracking> _trackingRepositorio;

        public TrackingServico(IRepositorio<Tracking> trackingRepositorio)
        {
            _trackingRepositorio = trackingRepositorio;
        }

        public List<Tracking> SelecionarTrackingPorCliente(long idCliente)
        {
            return _trackingRepositorio.Selecionar(x => x.IdCliente == idCliente, x => x.Cliente).ToList();
        }

        public List<Tracking> SelecionarTrackingPorDisparo(Guid disparo)
        {
            return _trackingRepositorio.Selecionar(x => x.IdDisparo == disparo, x => x.Cliente).ToList();
        }
    }
}
