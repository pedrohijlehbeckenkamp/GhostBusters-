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

        public IEnumerable<StatusEntity> GetAll()
        {
            var dbSet = context.Set<StatusEntity>();
            var dbSetPerfil = context.Set<PerfilEntity>();

            var result =
                from status in dbSet
                join perfil in dbSetPerfil on status.COD_PERFIL equals perfil.COD_PERFIL
                select
                    status;

            return result.ToList();
        }
    }
}
