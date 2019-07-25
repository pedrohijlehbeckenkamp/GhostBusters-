using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class LogModel
    {
        public int Codigo_Log { get; set; }
        public int Codigo_Usuario { get; set; }
        public int Codigo_Ant_Status { get; set; }
        public int Codigo_New_Status { get; set; }
        public int Codigo_Chamado { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_log { get; set; }

        public virtual Usuario Owner { get; set; }
        public virtual StatusModel Status_Ant { get; set; }
        public virtual StatusModel Status_New { get; set; }
        public virtual ChamadoModel Chamado { get; set; }

    }
}
