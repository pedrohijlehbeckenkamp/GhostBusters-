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

namespace GhostBusters_Forms.Usuário_Comum
{
    public partial class InicUsuarioComum : Form
    {
        public InicUsuarioComum()
        {
            InitializeComponent();
        }

        private void TelaUsuarioComum_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            //referenciar de acordo com o obj
            lblNomeUC.Text = "AAAA";
            lblEmail.Text = "BBB";
        }
       
        

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormAndHide<AlteraPic>();
        }
        private void BtnAdcTicket_Click(object sender, EventArgs e)
        {
            OpenFormAndHide<CadastrarTicket>();
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
