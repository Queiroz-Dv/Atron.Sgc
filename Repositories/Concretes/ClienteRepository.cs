using Atron.Sgc.Domain.Models;
using Atron.Sgc.Repositories.Interfaces;

namespace Atron.Sgc.Repositories.Concretes
{
    public class ClienteRepository : DadosRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository()
        {            
            if (Dados == null)
            {
                Dados = new List<Cliente>();
                Dados.Add(new(1, "Eduardo Queiroz", "eduardo.queiroz@email.com", "12345678910"));
                Dados.Add(new(2, "Naylane Andrade", "naylane.adrade@email.com", "33445588991"));
                Dados.Add(new(3, "Caio Lahud", "caio.lahud@email.com", "22778855440"));
            }
        }

        public Task GravarOuAtualizarClienteRepository(Cliente cliente)
        {
            var clienteBd = Dados.FirstOrDefault(clt => clt.CPF == cliente.CPF);
            if (clienteBd != null)
            {
                Dados.Remove(clienteBd);
                clienteBd = cliente;
            }

            Dados.Add(clienteBd);


            return Task.CompletedTask;
        }

        public Task<Cliente> ObterClientePorCPFRepository(string cpf)
        {
            return Task.FromResult(Dados.FirstOrDefault(clt => clt.CPF == cpf));
        }

        public Task<IList<Cliente>> ObterClientesRepository()
        {
            return Task.FromResult(Dados);
        }

        public Task<bool> RemoverClienteRepository(Cliente cliente)
        {
            Dados.Remove(cliente);

            var clienteExiste = Dados.Any(clt => clt.CPF == cliente.CPF);

            return Task.FromResult(clienteExiste);
        }
    }
}
