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
    public class ChamadoController
    {
        public ChamadoModel Cadastro(ChamadoModel chamado)
        {
            return new ChamadoRepository().CadastroUpdate(chamado.MapChamadaEntiy()).MapChamadaModel();
        } 
        public List<ChamadoModel> Findall()
        {
            return new ChamadoRepository().FindALL().Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }
        public void ExcluirChamado(ChamadoModel chamado)
        {
            for (int i = 0; i < chamado.anexos.Count; i++)
            {
                new AnexoController().ExcluirAnexo(chamado.anexos.ToArray()[i].Codigo_Anexo);
            }
            new ChamadoRepository().Excluir(chamado.Codigo_chamado);
        }
    }
}
