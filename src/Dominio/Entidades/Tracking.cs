using Dominio.Enum;
using System;

namespace Dominio.Entidades
{
    public class Tracking
    {
        protected Tracking()
        {

        }

        public Tracking(long id, Guid idDisparo, long idCliente, Cliente cliente, DisparoEnum disparo, CanalEnum canalDisparado, DateTime dataDisparo)
        {
            this.Id = id;
            this.IdDisparo = idDisparo;
            this.IdCliente = idCliente;
            this.Cliente = cliente;
            this.Disparo = disparo;
            this.CanalDisparado = canalDisparado;
            this.DataDisparo = dataDisparo;
        }

        public Tracking(Guid idDisparo, long idCliente, Cliente cliente, DisparoEnum disparo, CanalEnum canalDisparado, DateTime dataDisparo)
        {
            this.IdDisparo = idDisparo;
            this.IdCliente = idCliente;
            this.Cliente = cliente;
            this.Disparo = disparo;
            this.CanalDisparado = canalDisparado;
            this.DataDisparo = dataDisparo;
        }

        public long Id { get; private set; }
        public Guid IdDisparo { get; private set; }
        public long IdCliente { get; private set; }
        public Cliente Cliente { get; private set; }
        public DisparoEnum Disparo { get; private set; }
        public CanalEnum CanalDisparado { get; private set; }
        public DateTime DataDisparo { get; private set; }
    }
}
