using Atron.Sgc.Domain.Models;
using Atron.Sgc.Repositories.Interfaces;

namespace Atron.Sgc.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        protected readonly IList<T> _dados;

        public Repository(IList<T> initialData = null)
        {
            _dados = initialData != null ? [.. initialData] : new List<T>();
        }

        public Task<IList<T>> ObterTodos()
        {
            return Task.FromResult(_dados);
        }

        public Task<T> ObterPorId(int id)
        {
            var entity = _dados.FirstOrDefault(e => e.Id == id);
            return Task.FromResult(entity);
        }

        public Task Adicionar(T entity)
        {
            entity.Id = _dados.Any() ? _dados.Max(e => e.Id) + 1 : 1;
            _dados.Add(entity);
            return Task.CompletedTask;
        }

        public Task Atualizar(T entity)
        {
            var entidadeExiste = _dados.FirstOrDefault(e => e.Id == entity.Id);
            if (entidadeExiste != null)
            {
                var index = _dados.IndexOf(entidadeExiste);
                _dados[index] = entity;
            }
            return Task.CompletedTask;
        }

        public Task Deletar(int id)
        {
            var entidadeParaRemover = _dados.FirstOrDefault(e => e.Id == id);
            if (entidadeParaRemover != null)
            {
                _dados.Remove(entidadeParaRemover);
            }
            return Task.CompletedTask;
        }
    }
}