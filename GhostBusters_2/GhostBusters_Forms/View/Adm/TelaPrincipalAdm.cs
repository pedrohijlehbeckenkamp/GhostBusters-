using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View;
using GhostBusters_Forms.View.Adm;
using GhostBusters_Forms.View.Categoria;
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
using System.Text.RegularExpressions;
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
        private void Esconder()
        {
            this.Hide();
        }

        private void Abrir()
        {
            this.Show();
        }

        public void loadTelaprincipal()
        {
            tbConteudo.Visible = false;
            AlimentarCB();
            cbStatus.Visible = false;
            maskedCod.Visible = false;
            LoadImagem();
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            lblNomeAd.Text = usuario.NomeUsuario;
            lblEmail.Text = usuario.Email;
            dgVisualizar.AutoGenerateColumns = false;
            dgVisualizar.DataSource = new ChamadoController().Findall();
        }
        private void LoadImagem()
        {
            var imagem = new ImagemController().FindById(usuario.Codigo_imagem); ;
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
                //loadTelaprincipal();
                LoadImagem();
            };
            menu.Show();
            this.Hide();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirChamado excluir = new ExcluirChamado();
            excluir.Show();
            excluir.FormClosed += (x, y) =>
            {
                this.Show();
                loadTelaprincipal();
            };
            excluir.Show();
            this.Hide();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;

            var menu = new CadastrarTicket(usuario, (ChamadoModel)linha);
            menu.FormClosed += (x, y) => 
            {
                this.Show();
                loadTelaprincipal();
            };
            menu.Show();
            this.Hide();
        }

        private void ButAddTecnico_Click(object sender, EventArgs e)
        {
            var item = dgVisualizar.CurrentRow.DataBoundItem;

            AddTechChamado addTech = new AddTechChamado((ChamadoModel)item);
            addTech.FormClosed += (x, y) =>
            {
                this.Show();
                loadTelaprincipal();
            };
            addTech.Show();
            this.Hide();
        }

        private void LinkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tela = new AlterarSenha(usuario);
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
                loadTelaprincipal();
            };
            tela.Show();
            Esconder(); ;
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            var menu = new VisualizarUsuarios();
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };
            menu.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cbOrderBy.Text == "Código ticket")
            {
                int Id = Convert.ToInt32(maskedCod.Text);

                var byId = new ChamadoController().FindByID(Id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = byId;
            }
            else if (cbOrderBy.Text == "Conteúdo")
            {
                string padrao = tbConteudo.Text;

                //var ChamadosModel = new ChamadoModel();

                var Chamados = new ChamadoController().Findall();

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < Chamados.Count; i++)
                {
                    if (Chamados[i].Descricao.Contains(padrao))
                    {
                        lista.Add(Chamados[i]);
                    }
                }
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            //else if (cbOrderBy.Text == "Data")
            //{
            //    //MessageBox.Show("Data");
            //    dgVisualizar.AutoGenerateColumns = false;
            //    dgVisualizar.DataSource = new ChamadoController().Findall();
            //}
            else if (cbOrderBy.Text == "Status")
            {
                var Status = (StatusModel)cbStatus.SelectedItem;
                int id = Status.codigo_status;

                var chamados = new ChamadoController().FindByStatus(id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            } else if (cbOrderBy.Text == "Todos")
            {
                loadTelaprincipal();
            }
        }
        private void AlimentarCB()
        {
            cbStatus.DataSource = new StatusController().FindAll();
            cbStatus.DisplayMember = "NomeStatus";
        }
        
        private void CbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderBy.Text == "Código ticket")
            {
                maskedCod.Visible = true;
            }
            else
            {
                maskedCod.Visible = false;
            }

            if (cbOrderBy.Text == "Status")
            {
                cbStatus.Visible = true;
            }
            else
            {
                cbStatus.Visible = false;
            }

            if (cbOrderBy.Text == "Conteúdo")
            {
                tbConteudo.Visible = true;
            }
            else
            {
                tbConteudo.Visible = false;
            }
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbOrderBy.Text == "Conteúdo")
            //{
            //    cbStatus.Visible = true;
            //}
            //else
            //{
            //    cbStatus.Visible = false;
            //}
        }
    }
}
