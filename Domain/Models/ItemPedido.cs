namespace Atron.Sgc.Domain.Models
{
    public class ItemPedido(long id,
                      long pedidoId,
                      long produtoId,
                      int quantidade,
                      decimal precoUnitario)
    {
        public long Id { get; set; } = id;
        public long PedidoId { get; set; } = pedidoId;
        public long ProdutoId { get; set; } = produtoId;
        public int Quantidade { get; set; } = quantidade;
        public decimal PrecoUnitario { get; set; } = precoUnitario;
    }
}

/*
 Regras de Negócio (Pedidos e Itens):

RN09: Ao criar um novo Pedido, o status inicial deve ser sempre Pendente.

RN10: Um Pedido deve estar associado a um Cliente existente e ativo.

RN11: Um Pedido deve conter pelo menos um ItemPedido.

RN12: Ao adicionar um ItemPedido, o PrecoUnitario deve ser "congelado", ou seja,
copiado do Preco do Produto no momento da criação do pedido. 
Isso garante que, se o preço do produto mudar no futuro, o valor deste pedido não será alterado.

RN13: O ValorTotal do Pedido deve ser a soma de (Quantidade * PrecoUnitario) de todos os seus ItemPedido. 
Este cálculo deve ser feito no back-end, não confiando em valores enviados pelo cliente.

RN14: Não é possível adicionar um produto Inativo a um novo pedido.
 */