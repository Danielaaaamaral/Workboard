﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workboard.Application.Enum;

namespace Workboard.Application.DTO
{
    public class TarefaLogDTO
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario { get; set; }
        public Status Status { get; set; }
        public DateTime DtaAlteracao { get; set; }

    }
 
}
