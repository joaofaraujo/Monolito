using Dados.Base;
using Dados.Contexto;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;
using Dominio.Servicos;
using SimpleInjector;

namespace IOC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            RegisterDominio(container);

            RegisterRepositorio(container);

            RegisterContexto(container);
        }

        private static void RegisterContexto(Container container)
        {
            /*CONTEXTO*/
            container.Register<ComunicacaoContexto, ComunicacaoContexto>(Lifestyle.Scoped);
        }

        private static void RegisterRepositorio(Container container)
        {
            /*REPOSITORIO*/
            container.Register<IRepositorio<Cliente>, Repositorio<Cliente>>(Lifestyle.Scoped);
            container.Register<IRepositorio<Tracking>, Repositorio<Tracking>>(Lifestyle.Scoped);
        }

        private static void RegisterDominio(Container container)
        {
            /*DOMINIO*/
            container.Register<IClienteServico, ClienteServico>(Lifestyle.Scoped);
            container.Register<IDisparadorServico, DisparadorServico>(Lifestyle.Scoped);
            container.Register<ITrackingServico, TrackingServico>(Lifestyle.Scoped);
        }
    }
}