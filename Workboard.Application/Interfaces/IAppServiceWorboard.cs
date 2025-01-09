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
        void ComentarioAdd(ComentarioDTO obj);

        ComentarioDTO ComentarioGetById(int id);

        IEnumerable<ComentarioDTO> ComentarioGetAll();

        void ComentarioUpdate(ComentarioDTO obj);

        void ComentarioRemove(ComentarioDTO obj);
        #endregion
        #region Projeto
        void ProjetoAdd(ProjetoDTO obj);

        ProjetoDTO ProjetoGetById(int id);

        IEnumerable<ProjetoDTO> ProjetoGetAll();

        void ProjetoUpdate(ProjetoDTO obj);

        void ProjetoRemove(ProjetoDTO obj);
       ProjetoDTO GetByUserIdAsync(int userId);
        #endregion
        #region Tarefa
        void TarefaAdd(TarefaDTO obj);

        TarefaDTO TarefaGetById(int id);

        IEnumerable<TarefaDTO> TarefaGetAll();

        void TarefaUpdate(TarefaDTO obj);

        void TarefaRemove(TarefaDTO obj);
        #endregion

        #region TarefaLOG
        void TarefaLogAdd(TarefaLogDTO obj);

        TarefaLogDTO TarefaLogGetById(int id);

        IEnumerable<TarefaLogDTO> TarefaLogGetAll();

        void TarefaLogUpdate(TarefaLogDTO obj);

        void TarefaLogRemove(TarefaLogDTO obj);
        #endregion

    }
}
