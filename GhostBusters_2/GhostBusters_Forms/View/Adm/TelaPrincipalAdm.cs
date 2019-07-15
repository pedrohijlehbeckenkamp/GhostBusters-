using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Adm;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.View.Usuário_Comum;

namespace GhostBusters_Forms.Adm
{
    public partial class TelaPrincipalAdm : Form
    {
        private Usuario admin;
        public TelaPrincipalAdm(Usuario _admin)
        {
            InitializeComponent();
           admin = _admin;
        }

        private void TelaPrincipalAdm_Load(object sender, EventArgs e)
        {
            NomeAdimin.Text =admin.NomeUsuario;
        }

        private void BtnNewTicket_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarTicket();
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };

            menu.Show();
            this.Hide();
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var menu = new CadastroUsuario();
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };

            menu.Show();
            this.Hide();
        }


        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteraPic alteracao = new AlteraPic(admin);
            alteracao.Show();
        }
    }
}
