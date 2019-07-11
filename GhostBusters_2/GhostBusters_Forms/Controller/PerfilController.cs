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
    public class PerfilController
    {
        public Perfil BuscaNome(string nome)
        {
            return new PerfilRepository().findbyName(nome).MapPerfilModel();
        } 
    }
}
