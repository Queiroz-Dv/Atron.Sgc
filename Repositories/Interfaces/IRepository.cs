using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IList<T>> ObterTodos();
        Task<T> ObterPorId(int id);
        Task Adicionar(T entity);
        Task Atualizar(T entity);
        Task Deletar(int id);
    }
}