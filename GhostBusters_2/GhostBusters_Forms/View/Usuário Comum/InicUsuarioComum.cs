using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.View.Ticket;
using GhostBusters_Forms.View.Status;
using GhostBusters_Forms.View.Usuário_Comum;
using GhostBusters_Forms.Model;
using System.IO;

namespace GhostBusters_Forms.Usuário_Comum
{
    public partial class InicUsuarioComum : Form
    {
        private Usuario usuario;
        public InicUsuarioComum(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
        }

        private void TelaUsuarioComum_Load(object sender, EventArgs e)
        {
            dgVisualizar.ReadOnly = true;
            dgVisualizar.AutoGenerateColumns = false;
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            //referenciar de acordo com o obj
            lblNomeUC.Text = usuario.NomeUsuario;
            lblEmail.Text = usuario.Email;

            if (usuario.Foto != null)
            {
                byte[] bytes = Convert.FromBase64String(usuario.Foto.BaseData);
                using (MemoryStream ms = new MemoryStream(bytes))
                {

                    picBase64.Image = Image.FromStream(ms);
                }
            }
        }
       
        

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteraPic alteraPic = new AlteraPic(usuario);
            alteraPic.Show();

        }
        private void BtnAdcTicket_Click(object sender, EventArgs e)
        {
            var tela = new CadastrarTicket(usuario);
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
            };

            tela.Show();
            Esconder();
            //OpenFormAndHide<>();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OpenFormAndHide<EditarTicket>();
        }

        private void OpenFormAndHide<U>() where U: Form, new()
        {
            var tela = new U();
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
            };

            tela.Show();
            Esconder();
        }

        private void Esconder()
        {
            this.Hide();
        }

        private void Abrir()
        {
            this.Show();
        }
    }
}
