using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class Usuario
    {
        public int Codigo_Usuario { get; set; }
        public string NomeUsuario { get; set; }
        public  string Email { get; set; }
        public string Senha { get; set; }
        public Perfil perfil { get; set; }
        public Imagem Foto { get; set; }

    }
}
