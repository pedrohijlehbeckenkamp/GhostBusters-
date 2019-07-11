using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.Usuário_Comum
{
    public partial class TelaPUsuarioComumcs : Form
    {
        public TelaPUsuarioComumcs()
        {
            InitializeComponent();
        }

        private void Esconder()
        {
            this.Hide();
        }

        private void Abrir()
        {
            this.Show();
        }

        private void LinkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForAndHide<CadastroUsuario>();
           
        }
        private void BtnNewTicket_Click(object sender, EventArgs e)
        {
           // OpenForAndHide<>(); COLOCAR O TICKET AQUI
        }
        private void BtnAcompanhamento_Click(object sender, EventArgs e)
        {
            OpenForAndHide<AcompanhamentoUsuario>();
        }

        //abrir as telas 
        private void OpenForAndHide<T>() where T: Form, new()
        {

            var tela = new T();
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
            };

            tela.Show();
            Esconder();
        }

        private void PbPerfil_Click(object sender, EventArgs e)
        {
            
        }


    }
}
