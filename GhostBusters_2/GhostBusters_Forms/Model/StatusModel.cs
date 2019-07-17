using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class StatusModel
    {
        public int codigo_status { get; set; }
        public string NomeStatus { get; set; }
        public Perfil perfil { get; set; }
    }
}