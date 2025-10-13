using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IItemPedidoRepository
    {
        Task<IList<ItemPedido>> ObterItemPedidosRepository();

        Task<ItemPedido> ObterItemPedidoPorChaveRepository(long id);

        // Centraliza a gravação e update
        Task<bool> GravarOuAtualizarItemPedidoRepository(ItemPedido pedido);

        Task<bool> RemoverItemPedidoRepository(ItemPedido pedido);
    }
}
