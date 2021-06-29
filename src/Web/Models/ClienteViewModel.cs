using Dominio.Entidades;
using Dominio.Enum;

namespace Web.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {

        }

        public ClienteViewModel(Cliente cliente)
        {
            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.Email = cliente.Email;
            this.Celular = cliente.Celular;
        }

        public Cliente SetCliente()
        {
            var cliente = new Cliente(this.Nome, this.Email, this.Celular, this.CPF);
            cliente.AdicionarPreferencia(this.Canal);
            return cliente;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CPF { get; set; }
        public CanalEnum Canal { get; set; }
    }
}