namespace Atron.Sgc.Domain.Models
{
    public class Pedido
    {
        public long Id { get; private set; }
        public long ClienteId { get; private set; }
        public int MyProperty { get; private set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
