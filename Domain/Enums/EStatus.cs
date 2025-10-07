using System.ComponentModel;

namespace Atron.Sgc.Domain.Enums
{
    public enum EStatus
    {
        [Description("Pendente")]
        Pendente,

        [Description("Processando")]
        Processando,

        [Description("Enviado")]
        Enviado,

        [Description("Concluído")]
        Concluido,

        [Description("Cancelado")]
        Cancelado
    }
}
