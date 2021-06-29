using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces.Servico
{
    public interface IClienteServico
    {
        void InserirCliente(Cliente cliente);
        void AlterarCliente(Cliente cliente);
        void ExcluirCliente(Cliente cliente);
        List<Cliente> SelecionarClientes();
        Cliente ObterClientePorId(long id);
    }
}
