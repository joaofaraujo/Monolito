using Dominio.Entidades;
using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TrackingViewModel
    {
        public TrackingViewModel()
        {

        }

        public TrackingViewModel(Tracking tracking)
        {
            this.Id = tracking.Id;
            this.IdDisparo = tracking.IdDisparo;
            this.IdCliente = tracking.IdCliente;
            if(tracking.Cliente != null)
                this.Cliente = new ClienteViewModel(tracking.Cliente);
            this.Disparo = tracking.Disparo.ToString();
            this.CanalDisparado = tracking.CanalDisparado.ToString();
            this.DataDisparo = tracking.DataDisparo;
        }

        public long Id { get; set; }
        public Guid IdDisparo { get; set; }
        public long IdCliente { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public string Disparo { get; set; }
        public string CanalDisparado { get; set; }
        public DateTime DataDisparo { get; set; }
    }
}