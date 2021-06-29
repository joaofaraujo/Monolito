using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Servicos
{
    public class ClienteServico : IClienteServico
    {
        private readonly IRepositorio<Cliente> _clienteRepositorio;

        public ClienteServico(IRepositorio<Cliente> clienteRepositorio)
        {
            this._clienteRepositorio = clienteRepositorio;
        }

        public void AlterarCliente(Cliente cliente)
        {
            _clienteRepositorio.Atualizar(cliente);
        }

        public void ExcluirCliente(Cliente cliente)
        {
            _clienteRepositorio.Excluir(cliente);
        }

        public void InserirCliente(Cliente cliente)
        {
            _clienteRepositorio.Inserir(cliente);

        }

        public Cliente ObterClientePorId(long id)
        {
            return _clienteRepositorio.Selecionar(x => x.Id == id).SingleOrDefault();
        }

        public List<Cliente> SelecionarClientes()
        {
            return _clienteRepositorio.SelecionarTodos().ToList();
        }
    }
}
