using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Workboard.Application.Interfaces;

namespace Workboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatorioController : Controller
    {
        private readonly IAppServiceWorboard _service;
        private readonly IMapper _mapper;

        public RelatorioController(IAppServiceWorboard service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> GetRelatorio( int idUsuario)
        {
            try
            {
                var report = await _service.GetRelatorioAsync(idUsuario);
                return Ok(report);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
        }
    }
}
