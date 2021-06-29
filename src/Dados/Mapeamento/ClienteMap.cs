using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Mapeamento
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.ToTable("Cliente");
            this.HasKey(t => t.Id);
            this.Property(t => t.Nome).HasColumnType("VARCHAR").HasMaxLength(300).IsRequired();
            this.Property(t => t.CPF).HasColumnType("VARCHAR").HasMaxLength(11).IsRequired();
            this.Property(t => t.Email).HasColumnType("VARCHAR").HasMaxLength(300).IsRequired();
            this.Property(t => t.Celular).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
        }

    }
}
