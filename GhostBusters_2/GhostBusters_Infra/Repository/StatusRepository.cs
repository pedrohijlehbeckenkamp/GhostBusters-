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
    }
}
