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
        public DateTime DATA_CHAMADA_FINALIZADA { get; set; }
        public int COD_STATUS { get; set; }
        public int COD_ANEXO { get; set; }
        // [ForeignKey("COD_ANEXO")]
        //public Base64AnexoEntity ANEXO { get; set; }
        public ICollection<Base64AnexoEntity> ANEXOS { get; set; } = new HashSet<Base64AnexoEntity>();

        [ForeignKey("COD_STATUS")]
        public StatusEntity _STATUS { get; set; }
        public int COD_CATEGORIA { get; set; }

        [ForeignKey("COD_CATEGORIA")]
        public CategoriaEntity CATEGORIA { get; set; }
        public int COD_OWNER { get; set; }

        [ForeignKey("COD_OWNER")]
        public UsuarioEntity OWNER { get; set; }

        public int? COD_TECH { get; set; }

        [ForeignKey("COD_TECH")]
        public UsuarioEntity TECNICO { get; set; }


        public override int? EntityId()
        {
            return COD_CHAMADO;
        }



    }
}
