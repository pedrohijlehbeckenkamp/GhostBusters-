using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class StatusRepository: BaseRepository<StatusEntity>
    {
        public StatusEntity findbyName(string name)
        {
            return this.context.Set<StatusEntity>().FirstOrDefault(x => x.NOME == name);
        }

        public override StatusEntity CadastroUpdate(StatusEntity obj)
        {
            if(obj == null)
            {
                return null;
            }

            obj.COD_PERFIL = obj.PERFIL.COD_PERFIL;
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override StatusEntity Cadastro(StatusEntity obj)
        {
            var objStatus = context.Set<StatusEntity>().Add(obj);
            context.Entry(obj.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            context.SaveChanges();
            return objStatus;
        }

        private protected override StatusEntity Update(StatusEntity obj)
        {
            var finded = FindById(obj.EntityKey);
            context.Entry(finded).State = System.Data.Entity.EntityState.Detached;

            var objUpdate = context.Set<StatusEntity>().Attach(obj);
            context.Entry(objUpdate).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return objUpdate;
        }

    }
}
