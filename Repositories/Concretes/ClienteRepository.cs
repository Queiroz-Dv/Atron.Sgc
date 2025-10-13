using Atron.Sgc.Domain.Models;
using Atron.Sgc.Repositories.Interfaces;

namespace Atron.Sgc.Repositories.Concretes
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Task<bool> EmailExiste(string email)
        {
            return Task.FromResult(_dados.Any(clt => clt.Email == email));
        }
        
        public Task<Cliente> ObterClientePorCPFRepository(string cpf)
        {
            return Task.FromResult(_dados.FirstOrDefault(clt => clt.CPF == cpf));
        }
    }
}
