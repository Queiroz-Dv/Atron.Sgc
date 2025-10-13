using Atron.Sgc.Domain.Notificador;

namespace Atron.Sgc.Utils
{
    public static class NotificacaoExtensions
    {
        public static bool TemErros(this List<Notificar> notificacoes)
        {
            return notificacoes.Any(ntf => ntf.TipoMensagem == TipoMensagem.Erro);
        }
    }
}