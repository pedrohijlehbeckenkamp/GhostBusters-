﻿using GhostBusters_Forms.Mapper;
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
        public List<Usuario> FindAll()
        {
            return new UsuarioRepository().FindALL().Select(usuario => usuario.MapUsuarioModel()).ToList();
        }
        public Usuario Cadastro(Usuario usuario)
        {
            return new UsuarioRepository().CadastroUpdate(usuario.MapUsuarioEntity()).MapUsuarioModel();
        }
        public Usuario ValidaLogin(string email, string senha)
        {
            return new UsuarioRepository().findbyLogin(email, senha).MapUsuarioModel();
        }
        public List<Usuario> FindbyPerfil(string perfil)
        {
            return new UsuarioRepository().findbyPerfil(perfil).Select(usuario => usuario.MapUsuarioModel()).ToList();
        }

    }
}
