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
        public async Task<IActionResult> GetProjetoById(int Id)
        {
            var projects = _service.ProjetoGetById(Id);

            var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

            return Ok(projectDTOs);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllProjeto()
        {
            return Ok(_service.ProjetoGetAll());
        }
        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> GetProjetoByUser(int idUsuario)
        {

            var projects = _service.GetByUserIdAsync(idUsuario);

            var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

            return Ok(projectDTOs);
        }
        // POST
        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] ProjetoDTO projetoDTO)
        {
            if (projetoDTO == null)
                return BadRequest("As informações projeto são obrigatórios.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            _service.ProjetoAdd(projetoDTO);

            var projectDTO = _mapper.Map<ProjetoDTO>(projetoDTO);

            return CreatedAtAction(nameof(GetProjetoById), new { id = projectDTO.Id }, projectDTO);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {

            try
            {
                var projeto = _service.ProjetoGetById(id);
                if (projeto != null)
                    _service.ProjetoRemove(projeto);

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
