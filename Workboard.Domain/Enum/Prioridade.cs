using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Enum
{
    public enum Prioridade
    {
        [Description("BAIXA")]
        BAIXA,
        [Description("MEDIA")]
        MEDIA,
        [Description("ALTA")]
        ALTA
    }
}
