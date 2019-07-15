using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class ChamadoModel
    {
        public int Codigo_chamado { get; set; }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Chamado { get; set; }
        public DateTime Data_Chamado_finalizado { get; set; }
        public StatusModel statusModel { get; set; }
        public Perfil perfil { get; set; }
        public Usuario Owner { get; set; }
        public Usuario Tech { get; set; }
        public Categoria categoria { get; set; }

    }
}
