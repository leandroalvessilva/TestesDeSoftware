using System;
using System.Collections.Generic;
using System.Linq;

namespace Features.Core
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> ObterTodos();

        void Adicionar(T entity);
        void Remover(Guid entity);
        void Atualizar(T entity);
    }
}