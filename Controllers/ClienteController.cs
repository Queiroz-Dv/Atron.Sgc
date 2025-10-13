using Atron.Sgc.Domain.Models;
using Atron.Sgc.Domain.Validador;
using Atron.Sgc.Services.Interfaces;
using Atron.Sgc.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Atron.Sgc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _service;
        public readonly INotificador _notificador;

        public ClienteController(IClienteService clienteService, INotificador notificador)
        {
            _service = clienteService;
            _notificador = notificador;
        }

        [HttpGet]
        public Task<IList<Cliente>> ObterClientes()
        {
            var clientes = _service.ObterClientesService();
            return clientes;
        }

        [HttpPost, HttpPut("/{id}")]
        public async Task<IActionResult> GravarCliente(Cliente cliente, int id)
        {            
            await _service.GravarOuAtualizarClienteService(cliente, id);

            return _notificador.Notificacoes.TemErros() ?
                BadRequest(_notificador.Notificacoes) : CreatedAtAction(nameof(GravarCliente), _notificador.Notificacoes);

        }

        [HttpGet("/{cpf}")]
        public async Task<ActionResult<Cliente>> ObterPorCpf(string cpf)
        {
            var cliente = await _service.ObterClientePorCPFService(cpf);
            return cliente != null ? Ok(cliente) : BadRequest();
        }
    }
}
