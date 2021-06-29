using Dominio.Enum;
using System;

namespace Web.Models
{
    public class DisparadorViewModel
    {
        public long IdCliente { get; set; }
        public string Mensagem { get; set; }
        public CanalEnum Canal { get; set; }
        public Guid IdDisparo { get; set; }
    }
}