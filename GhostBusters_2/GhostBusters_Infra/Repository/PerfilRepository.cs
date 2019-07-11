using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class PerfilRepository: BaseRepository<PerfilEntity>
    {
        public PerfilEntity findbyName(string name)
        {
            return this.context.Set<PerfilEntity>().FirstOrDefault(x => x.NOME == name);
        }
    }
}
