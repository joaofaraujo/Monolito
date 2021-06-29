using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Dados.Mapeamento
{
    public class TrackingMap : EntityTypeConfiguration<Tracking>
    {
        public TrackingMap()
        {
            this.ToTable("Tracking");
            this.HasKey(t => t.Id);
            this.Property(t => t.IdDisparo).IsRequired();
            this.Property(t => t.Disparo).IsRequired();
            this.Property(t => t.CanalDisparado).IsRequired();
            this.Property(t => t.DataDisparo).IsRequired();
            this.HasRequired(t => t.Cliente).WithMany().HasForeignKey(x => x.IdCliente);
        }
    }
}
