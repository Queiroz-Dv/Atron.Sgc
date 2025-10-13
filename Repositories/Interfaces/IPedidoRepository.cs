using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IList<Pedido>> ObterPedidosRepository();
        
        Task<Pedido> ObterPedidoPorClienteIdOuCpfRepository(long clienteId, string cpf = null);

        // Centraliza a gravação e update
        Task<bool> GravarOuAtualizarPedidoRepository(Pedido pedido);

        Task<bool> RemoverPedidoRepository(Pedido pedido);
    }
}