using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IList<Cliente>> ObterClientesService();

        // Aqui estou definindo o CPF como busca princpal ao invés de usar um ID recebido pelo front
        Task<Cliente> ObterClientePorCPFService(string cpf);

        Task GravarOuAtualizarClienteService(Cliente cliente);

        Task<bool> RemoverClienteService(Cliente cliente);
    }
}
