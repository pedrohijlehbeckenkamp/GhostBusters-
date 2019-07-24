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

        public List<ChamadoModel> FindByStatus(int id)
        {
            return new ChamadoRepository().FindByStatus(id).Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByOwner(int codigo_owner)
        {
            return new ChamadoRepository().FindByOwner(codigo_owner).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByID(int codigo_chamado)
        {
            return new ChamadoRepository().FindById(codigo_chamado).Select(chamado => chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByTecnico(int codigo_tecnico)
        {
            return new ChamadoRepository().FindByTecnico(codigo_tecnico).Select(tecnico => tecnico.MapChamadaModel()).ToList();
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
