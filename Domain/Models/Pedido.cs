using Atron.Sgc.Domain.Enums;

namespace Atron.Sgc.Domain.Models
{
    public class Pedido
    {
        public Pedido(long id, long clienteId, EStatus status, string clienteCpf = null)
        {
            Id = id;
            ClienteId = clienteId;
            Status = status;
            DataPedido = DateTime.Now;
            ClienteCpf = clienteCpf ?? string.Empty;
        }

        public long Id { get; private set; }
        public long ClienteId { get; private set; }
        public string? ClienteCpf { get; set; }
        public EStatus Status { get; private set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
    }
}

/*
 Status do Pedido (Fluxo):

Pendente: Pedido criado, aguardando processamento.

Processando: Pedido confirmado, estoque foi reservado/debitado.

Enviado: Pedido despachado para o cliente.

Concluido: Pedido entregue e finalizado.

Cancelado: Pedido foi cancelado.
 */
