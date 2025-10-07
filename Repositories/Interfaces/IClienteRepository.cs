using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<IList<Cliente>> ObterClientesRepository();

        // Aqui estou definindo o CPF como busca princpal ao invés de usar um ID recebido pelo front
        Task<Cliente> ObterClientePorCPFRepository(string cpf);
                
        Task GravarOuAtualizarClienteRepository(Cliente cliente);

        Task<bool> RemoverClienteRepository(Cliente cliente);
    }
}