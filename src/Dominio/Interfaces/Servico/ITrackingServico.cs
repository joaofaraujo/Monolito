using Dominio.Entidades;
using Dominio.Enum;
using System;
using System.Collections.Generic;

namespace Dominio.Interfaces.Servico
{
    public interface ITrackingServico
    {
        List<Tracking> SelecionarTrackingPorDisparo(Guid disparo);
        List<Tracking> SelecionarTrackingPorCliente(long idCliente);
    }
}
