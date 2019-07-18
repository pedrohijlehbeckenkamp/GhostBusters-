using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Adm;
using GhostBusters_Forms.View.Tech;
using GhostBusters_Forms.View.Ticket;
using GhostBusters_Forms.View.Usuário_Comum;

namespace GhostBusters_Forms.View.Tech
{
    public partial class IniciTech : Form
    {
        private Usuario usuario;
        public IniciTech(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
        }

        private void InciTechcs_Load(object sender, EventArgs e)
        {
            LoadImagem();
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
            lblNomeTec.Text = usuario.NomeUsuario;
            lblEmailTec.Text = usuario.Email;
        }

        private void LoadImagem()
        {
            var imagem = usuario.Foto;
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbPerfil.Image = Image.FromStream(ms);

            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ConfigAdm formC = new ConfigAdm(usuario);
            formC.Show();
        }

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteraPic alteraPic = new AlteraPic(usuario);
            alteraPic.Show();
        }
    }
}
