using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        /// <summary>
        /// Faz a exclusão pela entidade
        /// </summary>
        /// <param name="objeto"></param>
        void Excluir(T objeto);
        /// <summary>
        /// Faz a exclusão pela clausula WHERE, podendo ser 0 a N exclusões
        /// </summary>
        /// <param name="predicate"></param>
        void Excluir(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// Inseri o objeto em memoria do Entity
        /// </summary>
        /// <param name="objeto"></param>
        void Inserir(T objeto);
        /// <summary>
        /// Altera o objeto em memoria do entity
        /// </summary>
        /// <param name="objeto"></param>
        void Atualizar(T objeto);
        /// <summary>
        /// Persiste tudo que esta em memoria no entity.
        /// </summary>
        /// <returns></returns>
        int Salvar();
        /// <summary>
        /// Selecionar por criterio
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        IQueryable<T> Selecionar(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Selecionar todos
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        IQueryable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes);
    }
}
