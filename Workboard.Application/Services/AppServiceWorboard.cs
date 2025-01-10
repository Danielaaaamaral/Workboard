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
        private readonly IUsuarioService _suarioService;

        private readonly IMapper mapper;

        public AppServiceWorboard(ITarefaService tarefaService, ITarefaLogService logService, IProjetoService projetoService, IComentarioService comentarioService, IUsuarioService suarioService, IMapper mapper)
        {
            _tarefaService = tarefaService;
            _logService = logService;
            _projetoService = projetoService;
            _comentarioService = comentarioService;
            _suarioService = suarioService;
            this.mapper = mapper;
        }
        #region Comentario
        public void ComentarioAdd(ComentarioDTO obj)
        {
            var com = mapper.Map<Comentario>(obj);
            _comentarioService.Add(com);
        }

        public IEnumerable<ComentarioDTO> ComentarioGetAll()
        {
            var comentarios = _comentarioService.GetAll();
            var comentariosDto = mapper.Map<IEnumerable<ComentarioDTO>>(comentarios);
            return comentariosDto;
        }

        public ComentarioDTO ComentarioGetById(int id)
        {
            var c = _comentarioService.GetById(id);
            var cDto = mapper.Map<ComentarioDTO>(c);
            return cDto;
        }

        public void ComentarioRemove(ComentarioDTO obj)
        {
            var comentario = mapper.Map<Comentario>(obj);
            _comentarioService.Remove(comentario);
        }

        public void ComentarioUpdate(ComentarioDTO obj)
        {
            var c = mapper.Map<Comentario>(obj);
            _comentarioService.Update(c);
        }
        #endregion
        #region Projeto
        public void ProjetoAdd(ProjetoDTO obj)
        {
            var pro = mapper.Map<Projeto>(obj);
            _projetoService.Add(pro);
        }

        public IEnumerable<ProjetoDTO> ProjetoGetAll()
        {
            var projetos = _projetoService.GetAll();
            var projetosDto = mapper.Map<IEnumerable<ProjetoDTO>>(projetos);
            return projetosDto;
        }

        public ProjetoDTO ProjetoGetById(int id)
        {
            var p = _projetoService.GetById(id);
            var pDto = mapper.Map<ProjetoDTO>(p);
            return pDto;
        }
       
        public ProjetoDTO GetByUserIdAsync(int userId)
        {
            var p = _projetoService.GetByUserIdAsync(userId);
            var pDto = mapper.Map<ProjetoDTO>(p);
            return pDto;
        }

        public void ProjetoRemove(ProjetoDTO obj)
        {
            var pe = mapper.Map<Projeto>(obj);
            _projetoService.Remove(pe);
        }

        public void ProjetoUpdate(ProjetoDTO obj)
        {
            var p = mapper.Map<Projeto>(obj);
            _projetoService.Update(p);
        }
        #endregion
        #region Tarefa
        public void TarefaAdd(TarefaDTO obj)
        {
            var tarefa = mapper.Map<Tarefa>(obj);
            _tarefaService.Add(tarefa);
        }

        public IEnumerable<TarefaDTO> TarefaGetAll()
        {
            var tarefa = _tarefaService.GetAll();
            var tarefaDto = mapper.Map<IEnumerable<TarefaDTO>>(tarefa);
            return tarefaDto;
        }

        public TarefaDTO TarefaGetById(int id)
        {
            var t = _tarefaService.GetById(id);
            var tDto = mapper.Map<TarefaDTO>(t);
            return tDto;
        }

        public void TarefaRemove(TarefaDTO obj)
        {
            var t = mapper.Map<Tarefa>(obj);
            _tarefaService.Remove(t);
        }

        public void TarefaUpdate(TarefaDTO obj)
        {
            var t = mapper.Map<Tarefa>(obj);
            _tarefaService.Update(t);
        }
        public IEnumerable<TarefaDTO> TarefaGetByIdProjeto(int id)
        {
            var tarefas = _tarefaService.TarefaGetByIdProjeto(id);
            var tarefasDTO = mapper.Map<IEnumerable<TarefaDTO>>(tarefas);
            return tarefasDTO;
        }

        #endregion
        #region Tarefa Log
        public void TarefaLogAdd(TarefaLogDTO obj)
        {
            var tarefa = mapper.Map<TarefaLog>(obj);
            _logService.Add(tarefa);
        }

        public IEnumerable<TarefaLogDTO> TarefaLogGetAll()
        {
            var tarefa = _logService.GetAll();
            var tarefaDto = mapper.Map<IEnumerable<TarefaLogDTO>>(tarefa);
            return tarefaDto;
        }

        public TarefaLogDTO TarefaLogGetById(int id)
        {
            var t = _logService.GetById(id);
            var tDto = mapper.Map<TarefaLogDTO>(t);
            return tDto;
        }

        public void TarefaLogRemove(TarefaLogDTO obj)
        {
            var tl = mapper.Map<TarefaLog>(obj);
            _logService.Remove(tl);
        }

        public void TarefaLogUpdate(TarefaLogDTO obj)
        {
            var pe = mapper.Map<TarefaLog>(obj);
            _logService.Update(pe);
        }

       

        #endregion
    }
}
