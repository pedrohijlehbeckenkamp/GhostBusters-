using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class AnexoController
    {
        public Anexo CadastroOrUpdate(Anexo anexo)
        {
            return new AnexoRepository().CadastroUpdate(anexo.MapAnexoEntity()).MapAnexoModel();
        }
        public void AddChamado(ChamadoModel chamadoModel)
        {
            new AnexoRepository().AddChamadoAoAnexo(chamadoModel.MapChamadaEntiy());
        }
    }
}
