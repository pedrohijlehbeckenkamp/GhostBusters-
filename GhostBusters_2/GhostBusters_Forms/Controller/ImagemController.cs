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
    public class ImagemController
    {
        public Imagem Cadastro(Imagem imagem)
        {
            return new ImagemRepository().CadastroUpdate(imagem.MapImagemEntity()).MapImagemModel();
        }
    }
}
