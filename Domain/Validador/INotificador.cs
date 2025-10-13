using Atron.Sgc.Domain.Notificador;

namespace Atron.Sgc.Domain.Validador
{
    public interface INotificador
    {
        public List<Notificar> Notificacoes { get; set; }
    }

    public class Notificador : INotificador
    {
        public List<Notificar> Notificacoes { get; set; }

        public Notificador()
        {
            Notificacoes = new List<Notificar>();
        }

    }
}