using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IList<Cliente>> ObterClientesService();
        
        Task<Cliente> ObterClientePorCPFService(string cpf);

        Task GravarOuAtualizarClienteService(Cliente cliente, int id);

        Task RemoverClienteService(int id);
    }
}
