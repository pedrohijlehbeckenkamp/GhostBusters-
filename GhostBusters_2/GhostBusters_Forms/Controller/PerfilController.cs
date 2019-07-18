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
        public PerfilModel BuscaNome(string nome)
        {
            return new PerfilRepository().findbyName(nome).MapPerfilModel();
        }
        public List<PerfilModel> FindAll()
        {
            return new PerfilRepository().FindALL().Select(perfil => perfil.MapPerfilModel()).ToList();
        }

        internal void Cadastro(PerfilModel perfilModel)
        {
            throw new NotImplementedException();
        }
    }
}
