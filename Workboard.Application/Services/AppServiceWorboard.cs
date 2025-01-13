using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Application.DTO;
using Workboard.Application.Interfaces;
using Workboard.Domain.Entities;
using Workboard.Domain.Services;

namespace Workboard.Application.Services
{
    public class AppServiceWorboard :IAppServiceWorboard
    {
        private readonly ITarefaService _tarefaService;
        private readonly ITarefaLogService _logService;
        private readonly IProjetoService _projetoService;
        private readonly IComentarioService _comentarioService;
        private readonly IUsuarioService _usuarioService;

        private readonly IMapper mapper;

        public AppServiceWorboard(ITarefaService tarefaService, ITarefaLogService logService, IProjetoService projetoService, IComentarioService comentarioService, IUsuarioService suarioService, IMapper mapper)
        {
            _tarefaService = tarefaService;
            _logService = logService;
            _projetoService = projetoService;
            _comentarioService = comentarioService;
            _usuarioService = suarioService;
            this.mapper = mapper;
        }
        #region Comentario
        public async Task ComentarioAdd(ComentarioDTO obj)
        {
            var com = mapper.Map<Comentario>(obj);
            await _comentarioService.Add(com);
        }

        public async Task<IEnumerable<ComentarioDTO>> ComentarioGetAll()
        {
            var comentarios = await _comentarioService.GetAll();
            var comentariosDto = mapper.Map<IEnumerable<ComentarioDTO>>(comentarios);
            return comentariosDto;
        }

        public async Task<ComentarioDTO> ComentarioGetById(int id)
        {
            var c = await _comentarioService.GetById(id);
            var cDto = mapper.Map<ComentarioDTO>(c);
            return cDto;
        }

        public async Task ComentarioRemove(ComentarioDTO obj)
        {
            var comentario = mapper.Map<Comentario>(obj);
           await _comentarioService.Remove(comentario);
        }

        public async Task ComentarioUpdate(ComentarioDTO obj)
        {
            var c = mapper.Map<Comentario>(obj);
           await _comentarioService.Update(c);
        }
        #endregion
        #region Projeto
        public async Task ProjetoAdd(ProjetoDTO obj)
        {
            var pro = mapper.Map<Projeto>(obj);
            await _projetoService.Add(pro);
        }

        public async Task<IEnumerable<ProjetoDTO>> ProjetoGetAll()
        {
            var projetos =await _projetoService.GetAll();
            var projetosDto = mapper.Map<IEnumerable<ProjetoDTO>>(projetos);
            return projetosDto;
        }

        public async Task<ProjetoDTO> ProjetoGetById(int id)
        {
            var p = await _projetoService.GetById(id);
            var pDto = mapper.Map<ProjetoDTO>(p);
            return pDto;
        }
       
        public async Task<ProjetoDTO> GetByUserIdAsync(int userId)
        {
            var p = await _projetoService.GetByUserIdAsync(userId);
            var pDto = mapper.Map<ProjetoDTO>(p);
            return pDto;
        }

        public async Task ProjetoRemove(ProjetoDTO obj)
        {
            var pe = mapper.Map<Projeto>(obj);
           await _projetoService.Remove(pe);
        }

        public async Task ProjetoUpdate(ProjetoDTO obj)
        {
            var p = mapper.Map<Projeto>(obj);
           await _projetoService.Update(p);
        }
        #endregion
        #region Tarefa
        public async Task TarefaAdd(TarefaDTO obj)
        {
            var tarefa = mapper.Map<Tarefa>(obj);
            await _tarefaService.Add(tarefa);
        }

        public async Task<IEnumerable<TarefaDTO>> TarefaGetAll()
        {
            var tarefa = await _tarefaService.GetAll();
            var tarefaDto = mapper.Map<IEnumerable<TarefaDTO>>(tarefa);
            return tarefaDto;
        }

        public async Task<TarefaDTO> TarefaGetById(int id)
        {
            var t =await _tarefaService.GetById(id);
            var tDto = mapper.Map<TarefaDTO>(t);
            return tDto;
        }

        public async Task TarefaRemove(TarefaDTO obj)
        {
            var t = mapper.Map<Tarefa>(obj);
            await _tarefaService.Remove(t);
        }

        public async Task TarefaUpdate(TarefaDTO obj)
        {
            var t = mapper.Map<Tarefa>(obj);
           await _tarefaService.Update(t);
        }
        public async Task<IEnumerable<TarefaDTO>> TarefaGetByIdProjeto(int id)
        {
            var tarefas = await _tarefaService.TarefaGetByIdProjeto(id);
            var tarefasDTO = mapper.Map<IEnumerable<TarefaDTO>>(tarefas);
            return tarefasDTO;
        }

        #endregion
        #region Tarefa Log
        public async Task TarefaLogAdd(TarefaLogDTO obj)
        {
            var tarefa = mapper.Map<TarefaLog>(obj);
            await _logService.Add(tarefa);
        }

        public async Task<IEnumerable<TarefaLogDTO>> TarefaLogGetAll()
        {
            var tarefa =await _logService.GetAll();
            var tarefaDto = mapper.Map<IEnumerable<TarefaLogDTO>>(tarefa);
            return tarefaDto;
        }

        public async Task<TarefaLogDTO> TarefaLogGetById(int id)
        {
            var t =await _logService.GetById(id);
            var tDto = mapper.Map<TarefaLogDTO>(t);
            return tDto;
        }

        public async Task TarefaLogRemove(TarefaLogDTO obj)
        {
            var tl = mapper.Map<TarefaLog>(obj);
            await _logService.Remove(tl);
        }

        public async Task TarefaLogUpdate(TarefaLogDTO obj)
        {
            var pe = mapper.Map<TarefaLog>(obj);
           await _logService.Update(pe);
        }



        #endregion
        #region Relatorio
        public async Task<Relatorio>GetRelatorioAsync(int IdUsuario)
        {
            try
            {

                var user = await _usuarioService.GetById(IdUsuario);
                if( user != null && user.TipoUsuario.Equals("Gerente"))
                {
                    throw new UnauthorizedAccessException("Usuário não tem permissão para gerar este relatório.");
                }
                
                DateTime dtaVenci = DateTime.UtcNow.AddDays(-30);
                var conteudo = await _tarefaService.Relatorio(dtaVenci);
                var IdTarefas = conteudo.Select(x=>x.Id).ToList();
                var IdUsuarios = conteudo.Select(x=>x.Projeto.IdUsuario).ToList();
                int countTarefas = conteudo.Count();

                var report = new Relatorio
                { 
                    TotalTarefas = countTarefas,
                    TotalUsuarios = IdUsuarios.Count(),
                    ListIdUsuarios = IdUsuarios,
                    ListIdTarefas = IdTarefas,
                    DataVencimento = dtaVenci,
                    DataRelatorio = DateTime.UtcNow,
                };
                return report;
            }
            catch (Exception )
            {

                throw;
            }

        }
        #endregion
    }
}
