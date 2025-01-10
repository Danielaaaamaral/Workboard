using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard.Domain.Entities
{
    public class Relatorio
    {
        public int TotalTarefas { get; set; }
        public int TotalUsuarios { get; set; }
        public  List<int> ListIdUsuarios { get; set; }
        public List<int> ListIdTarefas { get; set; }
        public DateTime DataVencimento { get; set; } 
        public  DateTime DataRelatorio{ get; set; }= DateTime.Now;

        public Relatorio() { }
    }
}
