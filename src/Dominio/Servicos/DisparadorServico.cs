using Dominio.Entidades;
using Dominio.Enum;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;
using System;

namespace Dominio.Servicos
{
    public class DisparadorServico : IDisparadorServico
    {
        private readonly IRepositorio<Tracking> _trackingRepositorio;
        private readonly IClienteServico _clienteServico;

        public DisparadorServico(IRepositorio<Tracking> trackingRepositorio, IClienteServico clienteServico)
        {
            this._trackingRepositorio = trackingRepositorio;
            this._clienteServico = clienteServico;
        }

        public Guid RealizarDisparoCliente(long idCliente, string mensagem, CanalEnum canal)
        {
            var identificadoDisparo = Guid.NewGuid();
            var cliente = _clienteServico.ObterClientePorId(idCliente);
            var trackingDisparo = new Tracking(identificadoDisparo, idCliente, cliente, DisparoEnum.Disparado, canal, DateTime.Now);
            _trackingRepositorio.Inserir(trackingDisparo);

            switch (canal)
            {
                case CanalEnum.Email:
                    break;
                case CanalEnum.SMS:
                    break;
            }

            var trackingRecebido = new Tracking(identificadoDisparo, idCliente, cliente, DisparoEnum.Recebido, canal, DateTime.Now);
            _trackingRepositorio.Inserir(trackingRecebido);

            return identificadoDisparo;
        }
    }
}
