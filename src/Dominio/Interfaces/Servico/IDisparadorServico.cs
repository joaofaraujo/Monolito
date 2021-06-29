using Dominio.Enum;
using System;

namespace Dominio.Interfaces.Servico
{
    public interface IDisparadorServico
    {
        Guid RealizarDisparoCliente(long idCliente, string mensagem, CanalEnum canal);
    }
}
