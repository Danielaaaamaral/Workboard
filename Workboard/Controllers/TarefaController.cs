using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Workboard.Application.DTO;
using Workboard.Application.Interfaces;
using Workboard.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly IAppServiceWorboard _service;
        private readonly IMapper _mapper;

        public TarefaController(IAppServiceWorboard service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        // GET: 
        [HttpGet("Projeto/{Idprojeto}")]
        public async Task<IActionResult> GetbyIdProjeto(int Idprojeto)
        {
            try { 
            var tarefas = _service.TarefaGetByIdProjeto(Idprojeto);
            return Ok(tarefas);
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

        // GET api/<TarefaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            try
            {
                var tarefa = _service.TarefaGetById(id);
                if (tarefa == null)
                    return BadRequest("Tarefa não encontrada");

                return Ok(tarefa);
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

        // POST api/<TarefaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarefaDTO tarefaDto)
        {
            try
            {
                 _service.TarefaAdd(tarefaDto);

                return Ok(tarefaDto);
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

        // PUT api/<TarefaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarefaDTO tarefa)
        {
            try
            {
                var tarefaExist = _service.TarefaGetById(id);
                if(tarefaExist != null)
                _service.TarefaUpdate(tarefa);

                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<TarefaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tarefa = _service.TarefaGetById(id);
                _service.TarefaRemove(tarefa);

                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
