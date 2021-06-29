using Dados.Mapeamento;
using Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Threading.Tasks;


namespace Dados.Contexto
{
    public class ComunicacaoContexto : DbContext
    {
        public ComunicacaoContexto() : base("Connection")
        {
            Database.SetInitializer<ComunicacaoContexto>(null);
            Database.Initialize(false);

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<PreferenciaComunicacao> PreferenciaComunicacao { get; set; }
        public DbSet<Tracking> Tracking { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PreferenciaComunicacaoMap());
            modelBuilder.Configurations.Add(new TrackingMap());
        }

        public int Salvar()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors) { foreach (var ve in eve.ValidationErrors) { } }
                throw;
            }
        }

        public Task<int> SalvarAsync()
        {
            try
            {
                return base.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors) { foreach (var ve in eve.ValidationErrors) { } }
                throw;
            }
        }

    }
}
