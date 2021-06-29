using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using EntityState = System.Data.Entity.EntityState;
using Dominio.Interfaces.Repositorio;
using Dados.Contexto;

namespace Dados.Base
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {
        private readonly ComunicacaoContexto _contexto;
        private bool _disposed;

        public Repositorio(ComunicacaoContexto contexto)
        {
            _contexto = contexto;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _contexto?.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<T> Selecionar(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _contexto.Set<T>().AsQueryable();
            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            query = query.Where(predicate).AsQueryable();

            return query;
        }

        public virtual IQueryable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes)
        {
            var query = _contexto.Set<T>().AsQueryable();
            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }

        public virtual void Excluir(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            Salvar();
        }

        public virtual void Excluir(Expression<Func<T, bool>> predicate)
        {
            _contexto.Set<T>().Where(predicate).ToList().ForEach(del => _contexto.Set<T>().Remove(del));
            Salvar();
        }

        public virtual void Inserir(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            Salvar();
        }

        public virtual void Atualizar(T objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            Salvar();
        }
        public int Salvar()
        {
            return _contexto.Salvar();
        }
    }
}
