using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("CHAMADO")]
    public class ChamadoEntity: BaseEntity
    {
        [Key]
        public int COD_CHAMADO { get; set; }
        
        public string TITULO { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATA_CHAMADO { get; set; }
        public int COD_STATUS { get; set; }

        [ForeignKey("_STATUS")]
        public StatusEntity _STATUS { get; set; }
        public int COD_CATEGORIA { get; set; }

        [ForeignKey("CATEGORIA")]
        public CategoriaEntity CATEGORIA { get; set; }
        public int COD_OWNER { get; set; }

        [ForeignKey("USUARIO")]
        public UsuarioEntity OWNER { get; set; }

        public int? COD_TECH { get; set; }
        public UsuarioEntity TECNICO { get; set; }


        public override int? EntityId()
        {
            return COD_CHAMADO;
        }



    }
}
