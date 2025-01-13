using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Application.DTO;
using Workboard.Domain.Entities;

namespace Workboard.Application.Interfaces
{
    public interface IAppServiceWorboard
    {
        #region Comentario
        Task ComentarioAdd(ComentarioDTO obj);

        Task<ComentarioDTO> ComentarioGetById(int id);

        Task<IEnumerable<ComentarioDTO>> ComentarioGetAll();

        Task ComentarioUpdate(ComentarioDTO obj);

        Task ComentarioRemove(ComentarioDTO obj);
        #endregion
        #region Projeto
        Task ProjetoAdd(ProjetoDTO obj);

        Task<ProjetoDTO> ProjetoGetById(int id);

        Task<IEnumerable<ProjetoDTO>> ProjetoGetAll();

        Task ProjetoUpdate(ProjetoDTO obj);

        Task ProjetoRemove(ProjetoDTO obj);
        Task<ProjetoDTO> GetByUserIdAsync(int userId);
        #endregion
        #region Tarefa
        Task TarefaAdd(TarefaDTO obj);

        Task<TarefaDTO> TarefaGetById(int id);
        Task<IEnumerable<TarefaDTO>> TarefaGetByIdProjeto(int id);

        Task<IEnumerable<TarefaDTO>> TarefaGetAll();

        Task TarefaUpdate(TarefaDTO obj);

        Task TarefaRemove(TarefaDTO obj);
        #endregion

        #region TarefaLOG
        Task TarefaLogAdd(TarefaLogDTO obj);

        Task<TarefaLogDTO> TarefaLogGetById(int id);

        Task<IEnumerable<TarefaLogDTO>> TarefaLogGetAll();

        Task TarefaLogUpdate(TarefaLogDTO obj);

        Task TarefaLogRemove(TarefaLogDTO obj);
        #endregion

        Task<Relatorio> GetRelatorioAsync(int IdUsuario);

    }
}
