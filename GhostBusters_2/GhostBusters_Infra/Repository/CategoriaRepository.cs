using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class CategoriaRepository : BaseRepository<CategoriaEntity>
    {

        public override CategoriaEntity CadastroUpdate(CategoriaEntity obj)
        {
            if(obj == null)
            {
                return null;
            }

            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override CategoriaEntity Cadastro(CategoriaEntity obj)
        {
            var objCadastro = context.Set<CategoriaEntity>().Add(obj);
            context.SaveChanges();

            return objCadastro;
        }

        private protected override CategoriaEntity Update(CategoriaEntity obj)
        {
            var findout = FindById(obj.EntityKey);
            context.Entry(findout).State = System.Data.Entity.EntityState.Detached;

            var objUpdateC = context.Set<CategoriaEntity>().Attach(obj);
            context.Entry(objUpdateC).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();

            return objUpdateC;
        }
    }
}
