using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms
{
    public partial class EditarUsuarios : Form
    {

        private Usuario usuario;

        public EditarUsuarios(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuario = _usuario;
        }

        private void EditarUsuarios_Load(object sender, EventArgs e)
        {
            ValidaSenha();

            if (usuario.perfil.nomePerfil == "Técnico")
            {
                lbNome.Text = usuario.NomeUsuario;
                lbPerfil.Text = usuario.NomePerfil;
                lbEmail.Text = usuario.Email;
            }
            else if (usuario.perfil.nomePerfil == "Usuario")
            {
                lbNome.Text = usuario.NomeUsuario;
                lbPerfil.Text = usuario.NomePerfil;
                lbEmail.Text = usuario.Email;
            };
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {
            if (((usuario.perfil.nomePerfil == "Técnico") && (usuario.Senha == usuario.Email))
                || (usuario.perfil.nomePerfil == "Usuario") && (usuario.Senha == usuario.Email))
            {
                //tb
                //MessageBox.Show("merdaaaa");
            }

        }

        private bool ValidaSenha()
        {
            if(string.IsNullOrEmpty(tbNovaSenha.Text) || string.IsNullOrEmpty(tbConfSenha.Text) || tbNovaSenha.Text != tbConfSenha.Text || tbNovaSenha.Text.Length <6)
            {
                tbConfSenha.BackColor = Color.White;
                tbNovaSenha.BackColor = Color.White;
            }
            else
            {
                tbConfSenha.BackColor = Color.White;
                tbNovaSenha.BackColor = Color.White;
            }
            return true;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (((usuario.perfil.nomePerfil == "Técnico") && (usuario.Senha == tbSenha.Text))
               || (usuario.perfil.nomePerfil == "Usuario") && (usuario.Senha == tbSenha.Text))
            {
                if (tbNovaSenha.Text == tbConfSenha.Text)
                {
                    new UsuarioController().Cadastro(Update());
                    
                    MessageBox.Show(tbConfSenha.Text);
                }
                else
                {
                    MessageBox.Show("merdaaaa");
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta");
                tbSenha.BackColor = Color.Red;
            }
        }

        private Usuario Update() 
        {
            Usuario Upusuario = usuario;
            Upusuario.Senha = tbConfSenha.Text;
            return Upusuario;
        }
    }
}
