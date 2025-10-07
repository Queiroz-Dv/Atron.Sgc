using Atron.Sgc.Domain.Models;
using Atron.Sgc.Repositories.Interfaces;
using Atron.Sgc.Services.Interfaces;

namespace Atron.Sgc.Services.Concretes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository) => _repository = repository;

        public Task GravarOuAtualizarClienteService(Cliente cliente)
        {
            return _repository.GravarOuAtualizarClienteRepository(cliente);
        }

        public Task<Cliente> ObterClientePorCPFService(string cpf)
        {
            return _repository.ObterClientePorCPFRepository(cpf);
        }

        public Task<IList<Cliente>> ObterClientesService()
        {
            return _repository.ObterClientesRepository();
        }

        public Task<bool> RemoverClienteService(Cliente cliente)
        {
            return _repository.RemoverClienteRepository(cliente);
        }
    }
}
