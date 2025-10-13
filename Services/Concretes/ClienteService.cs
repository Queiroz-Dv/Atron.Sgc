using Atron.Sgc.Domain.Models;
using Atron.Sgc.Domain.Notificador;
using Atron.Sgc.Domain.Validador;
using Atron.Sgc.Repositories.Interfaces;
using Atron.Sgc.Services.Interfaces;
using Atron.Sgc.Utils;

namespace Atron.Sgc.Services.Concretes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IValidador<Cliente> _validador;
        private readonly INotificador _notificador;

        public ClienteService(
            IClienteRepository repository,
            IValidador<Cliente> validador,
            INotificador notificador)
        {
            _repository = repository;
            _validador = validador;
            _notificador = notificador;
        }

        public async Task GravarOuAtualizarClienteService(Cliente cliente, int id)
        {
            _validador.Validar(cliente);

            bool emailExiste = await _repository.EmailExiste(cliente.Email);

            if (emailExiste)
                _notificador.Notificacoes.Add(new Notificar("Email já utilizado. Tente outro.", TipoMensagem.Erro));

            if (!_notificador.Notificacoes.TemErros())
            {
                if (id != 0)
                {
                    await _repository.Adicionar(cliente);
                    _notificador.Notificacoes.Add(new("Cliente gravado com sucesso", TipoMensagem.Sucesso));
                }
                else
                {
                    await _repository.Atualizar(cliente);
                    _notificador.Notificacoes.Add(new("Cliente atualizado com sucesso", TipoMensagem.Sucesso));
                }
            }

            return;
        }

        public Task<Cliente> ObterClientePorCPFService(string cpf)
        {
            return _repository.ObterClientePorCPFRepository(cpf);
        }

        public Task<IList<Cliente>> ObterClientesService()
        {
            return _repository.ObterTodos();
        }

        public Task RemoverClienteService(int id)
        {
            return _repository.Deletar(id);
        }
    }
}

/*
 Regras de Negócio:

RN01: O Email deve ser único na base de dados. O sistema não pode permitir o cadastro de dois clientes com o mesmo e-mail.

RN02: O CPF deve ser único. Validações de formato (11 dígitos numéricos) devem ser aplicadas.

RN03: Um cliente pode ser inativado (Ativo = false). Clientes inativos não podem 
realizar novos pedidos, mas seus pedidos antigos devem permanecer no histórico.

RN04: A exclusão de um cliente (exclusão física) só deve ser permitida
se ele não possuir nenhum pedido associado. Caso contrário, apenas a inativação é permitida (exclusão lógica).
 */