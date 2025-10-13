using System.ComponentModel;

namespace Atron.Sgc.Domain.Notificador
{
    public class Notificar(string messagem, TipoMensagem tipoMensagem)
    {
        public string Messagem { get; set; } = messagem;
        public TipoMensagem TipoMensagem { get; set; } = tipoMensagem;
    }

    public enum TipoMensagem
    {
        [Description("Erro")]
        Erro,
        [Description("Sucesso")]
        Sucesso,
        [Description("Aviso")]
        Aviso
    }
}