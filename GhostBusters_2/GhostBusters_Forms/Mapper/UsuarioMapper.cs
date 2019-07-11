using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class UsuarioMapper
    {
        public static UsuarioEntity MapUsuarioEntity(this Usuario usuario)
        {
            return new UsuarioEntity()
            {
                COD_USUARIO = usuario.Codigo_Usuario,
                NOME = usuario.NomeUsuario,
                EMAIL = usuario.Email,
                SENHA = usuario.Senha,
                PERFIL = usuario.perfil.MapPerfilEntity(),
                IMAGEM = usuario.Foto.MapImagemEntity(),
            };
        }
        public static Usuario MapUsuarioModel(this UsuarioEntity usuarioEntity)
        {
            return new Usuario()
            {
                Codigo_Usuario = usuarioEntity.COD_USUARIO,
                NomeUsuario = usuarioEntity.NOME,
                Email = usuarioEntity.EMAIL,
                Senha = usuarioEntity.SENHA,
                Foto = usuarioEntity.IMAGEM.MapImagemModel(),
                perfil = usuarioEntity.PERFIL.MapPerfilModel()
            };
        }
    }
}
