using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {                
        Task<Cliente> ObterClientePorCPFRepository(string cpf);                       
        Task<bool> EmailExiste(string email);
    }
}