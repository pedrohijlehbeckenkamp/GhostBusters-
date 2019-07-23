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

namespace GhostBusters_Forms.View
{
    public partial class EditarUsuario : Form
    {
        private Usuario usuario;
        public EditarUsuario(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
            tbNome.Text = usuario.NomeUsuario;
            tbEmail.Text = usuario.Email;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
                new UsuarioController().Cadastro(Update());
                MessageBox.Show("Categoria cadastrada!");
                this.Close();
        }

        private Usuario Update()
        {
            Usuario u = usuario;

            u.NomeUsuario = tbNome.Text;
            u.Email = tbEmail.Text;

            return u;
        }
    }
}
