using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Workboard.Application.DTO;
using Workboard.Application.Interfaces;
using Workboard.Domain.Entities;

namespace Workboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetoController : Controller
    {
        private readonly IAppServiceWorboard _service;
        private readonly IMapper _mapper;

        public ProjetoController(IAppServiceWorboard service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectsById( int userId)
        {
            var projects =  _service.ProjetoGetById(userId);

            var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

            return Ok(projectDTOs);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllProjects()
        {
            return Ok(_service.ProjetoGetAll());
        }
        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> GetProjectsByUser( int idUsuario)
        {
           
            var projects =  _service.GetByUserIdAsync(idUsuario);

            var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

            return Ok(projectDTOs);
        }
    }
}
