using Dominio.Enum;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Cliente
    {
        protected Cliente()
        {

        }

        public Cliente(long id, string nome, string email, string celular, string cpf)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Celular = celular;
            this.CPF = cpf;
        }

        public Cliente(string nome, string email, string celular, string cpf)
        {
            this.Nome = nome;
            this.Email = email;
            this.Celular = celular;
            this.CPF = cpf;
        }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Celular { get; private set; }
        public string CPF { get; private set; }
        public List<PreferenciaComunicacao> Preferencias { get; private set; }
        
        public Cliente AdicionarPreferencia(CanalEnum canal)
        {
            if (this.Preferencias == null)
                this.Preferencias = new List<PreferenciaComunicacao>();

            this.Preferencias.Add(new PreferenciaComunicacao(this.Id, this, canal));

            return this;
        }
    }
}
