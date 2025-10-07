using Atron.Sgc.Domain.Models;
using Atron.Sgc.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Atron.Sgc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _service;

        public ClienteController(IClienteService clienteService)
        {
            _service = clienteService;
        }

        [HttpGet]
        public Task<IList<Cliente>> ObterClientes()
        {
            var clientes = _service.ObterClientesService().Result;
            return Task.FromResult(clientes);
        }
    }
}
