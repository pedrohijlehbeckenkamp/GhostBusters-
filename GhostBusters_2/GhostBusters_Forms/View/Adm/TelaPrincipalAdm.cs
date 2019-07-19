using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Adm;
using GhostBusters_Forms.View.Ticket;
using GhostBusters_Forms.View.Usuário_Comum;
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

namespace GhostBusters_Forms.Adm
{
    public partial class TelaPrincipalAdm : Form
    {
        private Usuario usuario;
        private ChamadoModel ticket;
        public TelaPrincipalAdm(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuario = _usuario;
        }

        private void TelaPrincipalAdm_Load(object sender, EventArgs e)
        {
            loadTelaprincipal();
        }
        public void loadTelaprincipal()
        {
            LoadImagem();
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            lblNomeAd.Text = usuario.NomeUsuario;
            lblEmail.Text = usuario.Email;
            dgVisualizar.AutoGenerateColumns = false;
            dgVisualizar.DataSource = new ChamadoController().Findall(); ;
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

        private void BtnNewTicket_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarTicket(usuario);
            menu.FormClosed += (x, y) =>
            {
                this.Show();
                loadTelaprincipal();
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
                loadTelaprincipal();
            };
            menu.Show();
            this.Hide();
        }

        private void BtnConfig_Click(object sender, EventArgs e) /// MUDEEEEI
        {
            ConfigAdm formaC = new ConfigAdm(usuario);
            formaC.Show();
        }

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*AlteraPic alteraPic = new AlteraPic(usuario);
            alteraPic.Show();*/

            var menu = new AlteraPic(usuario);
            menu.FormClosed += (x, y) =>
            {
                this.Show();
                loadTelaprincipal();
                //LoadImagem()
            };
            menu.Show();
            this.Hide();
        }

        private void DgVisualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = dgVisualizar.CurrentRow.DataBoundItem;

                AddTechChamado addTech = new AddTechChamado((ChamadoModel)item);
                addTech.Show();
                // MessageBox.Show("Nois");
            }
            catch (Exception)
            {

                MessageBox.Show("Deu ruim");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirChamado excluir = new ExcluirChamado();
            excluir.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;

            var menu = new CadastrarTicket(usuario, (ChamadoModel)linha);
            {
                this.Show();
                loadTelaprincipal();
                //LoadImagem()
            };
            menu.Show();
            this.Hide();
        }
    }
}
