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
    public class UsuarioController
    {
        public Usuario Cadastro(Usuario usuario)
        {
            return new UsuarioRepository().CadastroUpdate(usuario.MapUsuarioEntity()).MapUsuarioModel();
        }
        public Usuario ValidaLogin(string nome )
        {
            return new UsuarioRepository().findbyLogin(nome).MapUsuarioModel();
        }
    }
}
