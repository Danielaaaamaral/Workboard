using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Application.Enum
{
    public enum Status
    {
        [Description("PENDENTE")]
        PENDENTE,
        [Description("ANDAMENTO")]
        ANDAMENTO,
        [Description("CONCLUIDA")]
        CONCLUIDA

    }
}
