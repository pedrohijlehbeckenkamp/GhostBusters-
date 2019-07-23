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
            CenterToParent();
            usuario = _usuario;
        }
        private void Esconder()
        {
            this.Hide();
        }

        private void Abrir()
        {
            this.Show();
        }

        private void InciTechcs_Load(object sender, EventArgs e)
        {
            LoadTech();
        }
        private void LoadTech()
        {
            LoadImagem();
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
            lblNomeTec.Text = usuario.NomeUsuario;
            lblEmailTec.Text = usuario.Email;
            dgVisualizar.AutoGenerateColumns = false;
            var itens = new ChamadoController().FindByTecnico(usuario.Codigo_Usuario);
            dgVisualizar.DataSource = itens;
        }

        private void LoadImagem()
        {
            var imagem = new ImagemController().FindById(usuario.Codigo_imagem);
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbPerfil.Image = Image.FromStream(ms);

            }
        }

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteraPic alteraPic = new AlteraPic(usuario);
            alteraPic.Show();
            alteraPic.FormClosed += (x, y) =>
            {
                this.Show();
                LoadTech();
            };
            alteraPic.Show();
            this.Hide();
        }



        private void LinkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlterarSenha form = new AlterarSenha(usuario);
            form.Show();
            form.FormClosed += (x, y) =>
            {
                this.Show();
                LoadTech();
            };
            form.Show();
            this.Hide();
        }

        private void BtnAdcTicket_Click(object sender, EventArgs e)
        {
           // var linha = dgVisualizar.CurrentRow.DataBoundItem;
            if (dgVisualizar != null)
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var menu = new CadastrarTicket(usuario, (ChamadoModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    LoadTech();
                };
                menu.Show();
                this.Hide();
            }
            else MessageBox.Show("Nao existe Chamado para editar");
          
        }
    }
}