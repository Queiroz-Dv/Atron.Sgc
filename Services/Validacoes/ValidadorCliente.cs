using Atron.Sgc.Domain.Models;
using Atron.Sgc.Domain.Notificador;
using Atron.Sgc.Domain.Validador;

namespace Atron.Sgc.Services.Validacoes
{
    public class ValidadorCliente : Notificador, IValidador<Cliente>
    {                        
        public void Validar(Cliente entidade)
        {
            if (entidade.NomeCompleto.Length < 3)
            {
                Notificacoes.Add(new Notificar("Nome contém menos de 3 caracteres", TipoMensagem.Erro));
            }

            if (entidade.CPF.Length != 11)
            {
                Notificacoes.Add(new Notificar("CPF Inválido tente novamente.", TipoMensagem.Erro));
            }
        }
    }
}