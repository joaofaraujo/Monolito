using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Dados.Mapeamento
{
    public class PreferenciaComunicacaoMap : EntityTypeConfiguration<PreferenciaComunicacao>
    {
        public PreferenciaComunicacaoMap()
        {
            this.ToTable("PreferenciaComunicacao");
            this.HasKey(t => t.Id);
            this.Property(t => t.Canal).IsRequired();
            this.HasRequired(t => t.Cliente).WithMany(x => x.Preferencias).HasForeignKey(x => x.IdCliente);
        }
    }
}
