using Atron.Sgc.Domain.Models;

namespace Atron.Sgc.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IList<Produto>> ObterProdutosRepository();

        // Aqui estou definindo o SKU como busca princpal ao invés de usar um ID recebido pelo front
        Task<Produto> ObterProdutoPorSKURepository(string sku);

        // Centraliza a gravação e update
        Task<bool> GravarOuAtualizarProdutoRepository(Produto produto);

        Task<bool> RemoverProdutoRepository(Produto produto);
    }
}