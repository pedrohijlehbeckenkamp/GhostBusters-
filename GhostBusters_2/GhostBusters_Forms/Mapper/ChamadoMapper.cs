using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class ChamadoMapper
    {
        public static ChamadoEntity MapChamadaEntiy(this ChamadoModel chamadoModel)
        {
            if (chamadoModel == null)
            {
                return null;
            }

            return new ChamadoEntity()
            {
                COD_CHAMADO = chamadoModel.Codigo_chamado,
                TITULO = chamadoModel.Titulo,
                DESCRICAO = chamadoModel.Descricao,
                DATA_CHAMADO = chamadoModel.Data_Chamado,
                DATA_CHAMADA_FINALIZADA = chamadoModel.Data_Chamado_finalizado,
                ANEXOS = chamadoModel.anexos.Select(anexo => anexo.MapAnexoEntity()).ToList(),
               // ANEXO = chamadoModel.anexo.MapAnexoEntity(),
                CATEGORIA = chamadoModel.categoria.MapCategoriaEntity(),
                _STATUS = chamadoModel.statusModel.MapStatusEntity(),
                OWNER = chamadoModel.Owner.MapUsuarioEntity(),
                TECNICO = chamadoModel.Tech.MapUsuarioEntity()               
            };
        }

        public static ChamadoModel MapChamadaModel(this ChamadoEntity chamadoEntity)
        {
            if (chamadoEntity == null)
            {
                return null;
            }

            return new ChamadoModel()
            {
                Codigo_chamado = chamadoEntity.COD_CHAMADO,
                Titulo = chamadoEntity.TITULO,
                Descricao = chamadoEntity.DESCRICAO,
                Data_Chamado = chamadoEntity.DATA_CHAMADO,
                Data_Chamado_finalizado = chamadoEntity.DATA_CHAMADA_FINALIZADA,
                anexos = chamadoEntity.ANEXOS.Select(ANEXOS => ANEXOS.MapAnexoModel()).ToList(),
                //anexo =  chamadoEntity.ANEXO.MapAnexoModel(),
                categoria = chamadoEntity.CATEGORIA.MApCategoriaModel(),
                statusModel =  chamadoEntity._STATUS.MapStatusModel(),
                Owner = chamadoEntity.OWNER.MapUsuarioModel(),
                Tech = chamadoEntity.TECNICO.MapUsuarioModel()
            };
        }
    }
}
