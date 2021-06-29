using Dominio.Enum;

namespace Dominio.Entidades
{
    public class PreferenciaComunicacao
    {
        protected PreferenciaComunicacao()
        {

        }

        public PreferenciaComunicacao(long id, long idCliente, Cliente cliente, CanalEnum canal)
        {
            this.Id = id;
            this.IdCliente = idCliente;
            this.Cliente = cliente;
            this.Canal = canal;
        }

        public PreferenciaComunicacao(long idCliente, Cliente cliente, CanalEnum canal)
        {
            this.IdCliente = idCliente;
            this.Cliente = cliente;
            this.Canal = canal;
        }

        public long Id { get; private set; }
        public long IdCliente { get; private set; }
        public Cliente Cliente { get; private set; }
        public CanalEnum Canal { get; private set; }
    }
}
