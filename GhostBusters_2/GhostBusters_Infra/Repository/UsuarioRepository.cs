using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class UsuarioRepository: BaseRepository<UsuarioEntity>
    {
        public override UsuarioEntity CadastroUpdate(UsuarioEntity obj)//Cadastra ou Update
        {
            if (obj == null)
            {
                return null;
            }
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override UsuarioEntity Cadastro(UsuarioEntity obj)//Cadastrar um novo obj 
        {
            var objCadastro = context.Set<UsuarioEntity>().Add(obj);
            context.Entry(obj.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            if (obj.IMAGEM!=null)
                context.Entry(obj.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;

            context.SendChanges();
            return objCadastro;
        }
        protected override private UsuarioEntity Update(UsuarioEntity obj)//Update Obj
        {
            var objUpdated = context.Set<UsuarioEntity>().Attach(obj);
            context.Entry(objUpdated).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();
            return objUpdated;
        }
    }
}
