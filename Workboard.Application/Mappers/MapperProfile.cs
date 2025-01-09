using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Application.DTO;
using Workboard.Domain.Entities;

namespace Workboard.Application.Mappers
{
    public class MapperProfile : Profile
    {
        protected MapperProfile()
        {
            CreateMap<Projeto,ProjetoDTO>().ReverseMap();

            CreateMap<Tarefa, TarefaDTO>()
                .ReverseMap()
                .ForMember(x=>x.Comentarios,y=>y.MapFrom(c=>c.Comentarios))
                .ForMember(x => x.TarefaLog, y => y.MapFrom(c => c.logTarefa));

            CreateMap<TarefaLog, TarefaLogDTO>()
                .ReverseMap();
            CreateMap<Comentario, ComentarioDTO>().ReverseMap();


        }
    }
}
