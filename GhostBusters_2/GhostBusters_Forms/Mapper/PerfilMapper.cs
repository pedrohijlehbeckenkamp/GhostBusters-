using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class PerfilMapper
    {
        public static PerfilEntity MapPerfilEntity(this Perfil perfil)
        {
            return new PerfilEntity()
            {
                COD_PERFIL = perfil.Codigo,
                NOME = perfil.nomePerfil
            };
        }
        public static Perfil MapPerfilModel(this PerfilEntity entity)
        {
            return new Perfil()
            {
                Codigo = entity.COD_PERFIL,
                nomePerfil = entity.NOME
            };
        }
    }
}
