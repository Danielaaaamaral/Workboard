﻿using AutoMapper;
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
            try
            {
                var projects = await _service.ProjetoGetById(Id);

                var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

                return Ok(projectDTOs);
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
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>>GetAllProjeto()
        {
            try
            {
                return Ok(await _service.ProjetoGetAll());
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
        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> GetProjetoByUser(int idUsuario)
        {
            try
            {
                var projects =await _service.GetByUserIdAsync(idUsuario);

                var projectDTOs = _mapper.Map<IEnumerable<ProjetoDTO>>(projects);

                return Ok(projectDTOs);
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
        // POST
        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] ProjetoDTO projetoDTO)
        {
            try
            {
                if (projetoDTO == null)
                    return BadRequest("As informações projeto são obrigatórios.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _service.ProjetoAdd(projetoDTO);

                return Ok(projetoDTO);
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

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {

            try
            {
                var projeto =await _service.ProjetoGetById(id);
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
