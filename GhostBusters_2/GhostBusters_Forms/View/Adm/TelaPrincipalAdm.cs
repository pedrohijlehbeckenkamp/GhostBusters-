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
        string CB = "";
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
            AlimentarCB();
            tbConteudo.Visible = false;
            cbGeral.Visible = false;
            maskedCod.Visible = false;
            dtData.Visible = false;
            

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
                if (maskedCod.Text != "")
                {
                    int Id = Convert.ToInt32(maskedCod.Text);
                
                    var byId = new ChamadoController().FindChamadoByID(Id);

                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = byId;
                }
                else
                {
                    MessageBox.Show("Insira um Id válido.");
                }
            }
            else if (cbOrderBy.Text == "Conteúdo")
            {
                if (tbConteudo.Text != "")
                {
                    string padrao = tbConteudo.Text;

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
                else
                {
                    MessageBox.Show("Digite algo para fazer a pesquisa.");
                }
            }
            else if (cbOrderBy.Text == "Data")
            {
                DateTime date = dtData.Value.Date;

                var data = new ChamadoController().FindByDate(date);
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = data;
            }
            else if (cbOrderBy.Text == "Status")
            {
                var Status = (StatusModel)cbGeral.SelectedItem;
                int id = Status.codigo_status;

                var chamados = new ChamadoController().FindByStatus(id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            }
            else if (cbOrderBy.Text == "Usuário")
            {
                var Usuarios = (Usuario)cbGeral.SelectedItem;
                int id = Usuarios.Codigo_Usuario;

                var chamados = new ChamadoController().FindByUsuario(id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            }
            else if (cbOrderBy.Text == "Técnico")
            {
                var Usuarios = (Usuario)cbGeral.SelectedItem;
                int id = Usuarios.Codigo_Usuario;

                var chamados = new ChamadoController().FindByTech(id);
                
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            }
            else if (cbOrderBy.Text == "Categoria")
            {
                var Categoria = (CategoriaModel)cbGeral.SelectedItem;
                int id = Categoria.Codigo_categoria;

                var chamados = new ChamadoController().FindByCategoria(id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            }
            else if (cbOrderBy.Text == "Todos")
            {
                loadTelaprincipal();
            }
        }
        private void AlimentarCB()
        {
            
            if (CB == "Status")
            {
                cbGeral.DataSource = new StatusController().FindAll();
                cbGeral.DisplayMember = "NomeStatus";
            }
            else if (CB == "Usuário")
            {
                cbGeral.DataSource = new UsuarioController().FindbyPerfil("Usuario");
                cbGeral.DisplayMember = "NomeUsuario";
            }
            else if (CB == "Técnico")
            {
                cbGeral.DataSource = new UsuarioController().FindbyPerfil("Técnico");
                cbGeral.DisplayMember = "NomeUsuario";
            }
            else if (CB == "Categoria")
            {
                cbGeral.DataSource = new CategoriaController().FindByCategoria();
                cbGeral.DisplayMember = "NomeCategoria";
            }
        }

        private void CbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderBy.Text == "Código ticket")
            {
                CB = "Código ticket";
                maskedCod.Visible = true;
            }
            else
            {
                maskedCod.Visible = false;
            }

            if (cbOrderBy.Text == "Conteúdo")
            {
                CB = "Conteúdo";
                tbConteudo.Visible = true;
            }
            else
            {
                tbConteudo.Visible = false;
            }

            if (cbOrderBy.Text == "Data")
            {
                CB = "Data";
                dtData.Visible = true;
            }
            else
            {
                dtData.Visible = false;
            }

            if (cbOrderBy.Text == "Status")
            {
                CB = "Status";
                AlimentarCB();
                cbGeral.Visible = true;
            }

            else if (cbOrderBy.Text == "Usuário")
            {
                CB = "Usuário";
                AlimentarCB();
                cbGeral.Visible = true;
            }

            else if (cbOrderBy.Text == "Técnico")
            {
                CB = "Técnico";
                AlimentarCB();
                cbGeral.Visible = true;
            }
            else if (cbOrderBy.Text == "Categoria")
            {
                CB = "Categoria";
                AlimentarCB();
                cbGeral.Visible = true;
            }
            else
            {
                cbGeral.Visible = false;
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

        private void btAleterarStatus_Click(object sender, EventArgs e)
        {
            var item = dgVisualizar.CurrentRow.DataBoundItem;

            var addTech = new AlterarStatus(usuario, (ChamadoModel)item);
            addTech.FormClosed += (x, y) =>
            {
                this.Show();
                loadTelaprincipal();
            };
            addTech.Show();
            this.Hide();
        }
    }
}
