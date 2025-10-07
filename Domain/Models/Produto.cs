namespace Atron.Sgc.Domain.Models
{
    public class Produto
    {
        public Produto(long id,
                       string nome,
                       string descricao,
                       string sKU,
                       decimal preco,
                       int quantidadeEstoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            SKU = sKU;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public long Id { get; set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string SKU { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}

/*
 Regras de Negócio:

RN05: O SKU (código do produto) deve ser único.

RN06: O Preco de um produto não pode ser menor ou igual a zero.

RN07: A QuantidadeEstoque não pode ser negativa.

RN08: Um produto pode ser inativado (Ativo = false). Produtos inativos não podem ser adicionados a novos pedidos.
 */