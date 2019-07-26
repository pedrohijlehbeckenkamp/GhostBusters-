﻿using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.View.Ticket
{
    public partial class CadastrarTicket : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Usuario usuarioLogin;
        private ChamadoModel Chamado;
        private BindingList<Anexo> listaAnexo = new BindingList<Anexo>();
        public CadastrarTicket(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuarioLogin = _usuario;
        }

        public CadastrarTicket(Usuario _usuario, ChamadoModel _ticket)
        {
            InitializeComponent();
            CenterToParent();
            usuarioLogin = _usuario;
            Chamado = _ticket;
        }

        private void CadastrarTicket_Load(object sender, EventArgs e)
        {
            if (Chamado != null)
                LoadTicketEditar();
            else
                LoadTicketCadastro();

        }
        private void LoadTicketEditar()
        {
            tbTitulo.Text = Chamado.Titulo;
            tbDescricao.Text = Chamado.Descricao;
            LoadTecnico();
            LoadOwner();
            LoadAdmin();
            AddListaAnexo();
            dgAddAnexo.AutoGenerateColumns = false;
            dgAddAnexo.DataSource = listaAnexo;
            //tbTitulo.Visible = false;

        }
        private void LoadAdmin()
        {
            if (usuarioLogin.perfil.nomePerfil == "Admin")
            {
                //LoadComboBox();
                cbCategoria.DataSource = new CategoriaController().FindAll();
                //lbStatus.Visible = true;
                //cbStatus.Visible = true;
                tbNomeCategoria.Visible = false;
                cbCategoria.DisplayMember = "NomeCategoria";
                cbCategoria.SelectedIndex = cbCategoria.FindStringExact(Chamado.categoria.NomeCategoria);
                tbTitulo.Enabled = true;
            }
        }
        private void LoadComboBox()
        {
            //cbStatus.DataSource = new StatusController().FinByStatusPerfil(usuarioLogin.Codigo_perfil);
            //cbStatus.DisplayMember = "NomeStatus";
            //cbStatus.SelectedIndex = cbStatus.FindStringExact(Chamado.Nomestatus);
        }
        private void LoadOwner()
        {
            if (usuarioLogin.perfil.nomePerfil == "Usuario")
            {
                //LoadComboBox();
                //lbStatus.Visible = true;
                //cbStatus.Visible = true;
                tbNomeCategoria.Text = Chamado.categoria.NomeCategoria;
                cbCategoria.Visible = false;
                tbTitulo.Enabled = false;
            }
        }
        private void LoadTecnico()
        {
            if (usuarioLogin.perfil.nomePerfil == "Técnico")
            {
                //LoadComboBox();
                //lbStatus.Visible = true;
                //cbStatus.Visible = true;
                tbNomeCategoria.Text = Chamado.categoria.NomeCategoria;
                cbCategoria.Visible = false;
                tbTitulo.Enabled = false;
                tbDescricao.Enabled = false;
                butClearAnexo.Enabled = false;
            }
        }
        private void AddListaAnexo()
        {
           var listanexos = new AnexoController().FindbyChamado(Chamado.Codigo_chamado);
            for (int i = 0; i < listanexos.Count; i++)
            {
                listaAnexo.Add(listanexos[i]);
            }          
        }
        private void LoadTicketCadastro()
        {
            lbData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            //lbStatus.Visible = false;
            //cbStatus.Visible = false;
            cbCategoria.DataSource = new CategoriaController().FindAll();
            cbCategoria.DisplayMember = "NomeCategoria";
            dgAddAnexo.AutoGenerateColumns = false;
            tbNomeCategoria.Visible = false;
            dgAddAnexo.DataSource = listaAnexo;
            tbTitulo.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChamado();

        }
      
        public void SaveChamado()
        {
            int cont = 0;
            //var statusitem = (StatusModel)cbStatus.SelectedItem;
           if (Valida())
           {
              if (Chamado != null)
              {
                    if (Chamado.Owner.Codigo_perfil == Chamado.StatusChamado.codigo_perfil)
                    {
                        new StatusController().Cadastro(UpdateNullStatus());
                        cont++;
                    }

                    new ChamadoController().Cadastro(UpdateTicket());
                    new AnexoController().AddChamado(listaAnexo.ToList(), Chamado.Codigo_chamado);

                    if (cont > 0)
                        new StatusController().Cadastro(UpdateCodigoPrefilStatus());
                    this.Close();
                }
              else
              {
                   new ChamadoController().Cadastro(GetChamado());
                   this.Close();
              }
           }
      
        }
        private StatusModel UpdateNullStatus()
        {
            StatusModel status = Chamado.StatusChamado;
            status.codigo_perfil = null;
            status.perfil = null;
            return status;
        }
        private StatusModel UpdateCodigoPrefilStatus()
        {
            StatusModel status = Chamado.StatusChamado;
            status.codigo_perfil = Chamado.Owner.Codigo_perfil;
            status.perfil = Chamado.Owner.perfil;
            return status;
        }
        private bool Valida()
        {
            int cont = 0; 
            if (Validacoes.ValidaCamponull(tbTitulo.Text))
            {
                cont++;
                tbTitulo.BackColor = Color.Red;
                //MessageBox.Show("Campo Titulo vazio");
            }
            else tbTitulo.BackColor = Color.White;

            if (Validacoes.ValidaCamponull(tbDescricao.Text))
            {
                cont++;
                tbDescricao.BackColor = Color.Red;
                MessageBox.Show("Campo Titulo vazio");
            }
            else tbDescricao.BackColor = Color.White;

            if (cont > 0)
            {
                return false;
            }
            return true;
        }
        public ChamadoModel GetChamado() => new ChamadoModel()
        {
            Data_Chamado = DateTime.Now,
            Titulo = tbTitulo.Text,
            Descricao = tbDescricao.Text,
            anexos = listaAnexo.ToList(),
            categoria = (CategoriaModel)cbCategoria.SelectedItem,
            Owner = usuarioLogin            
        };
        private ChamadoModel UpdateTicket()
        {
            ChamadoModel UpChamado = Chamado;
            //UpChamado.StatusChamado = (StatusModel)cbStatus.SelectedItem;
            UpChamado.Titulo = tbTitulo.Text;
            UpChamado.Descricao = tbDescricao.Text;
            if (usuarioLogin.perfil.nomePerfil == "Admin")
                UpChamado.categoria = (CategoriaModel)cbCategoria.SelectedItem;
            return UpChamado;
        }
        public Anexo GetAnexo(FileInfo file) => new Anexo()
        {
            nomeAnexo = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName)),
            Extensao= file.Extension
        };

        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }else
            return null;
        }
        private void ButAddAnexo_Click(object sender, EventArgs e)
        {
            var location = AbrirAnexo();
            if (location != "")
            {
                FileInfo file = new FileInfo(location);
                listaAnexo.Add(GetAnexo(file));
            }

        }
        private string AbrirAnexo()
        {
            var fileDialog = GetOpenFileDialog();
            string location = "";
            if (fileDialog != null)
            {
                location = fileDialog.FileName;
                return location;
            }
            return location;
        }
        private void ButExcluirAnexo_Click(object sender, EventArgs e)
        {
           //Exclui o anexo 
            var anexoSelecionado = dgAddAnexo.CurrentRow.DataBoundItem;
            var anexo = (Anexo)anexoSelecionado;
            string message = "Deseija excluir o Anexo " + anexo.nomeAnexo;
            const string caption = "Form Closing";
            /*var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,//.YesNo,
                                         MessageBoxIcon.Question);*/
            var resultado = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                if (anexo.Codigo_Anexo == 0) listaAnexo.Remove(anexo);
                else
                {
                    new AnexoController().ExcluirAnexo(anexo.Codigo_Anexo);
                    listaAnexo.Remove(anexo);
                   // LoadTicketEditar();//Load apos excluir  
                }
            }
            dgAddAnexo.DataSource = listaAnexo;      
        }
        private void DgAddAnexo_DoubleClick(object sender, EventArgs e)
        {
            
            //Visualizar Chamado 
            var fileanexo = (Anexo)dgAddAnexo.CurrentRow.DataBoundItem;
            if (fileanexo != null)
            {                
                byte[] bytes = Convert.FromBase64String(fileanexo.BaseData);
                File.WriteAllBytes("C:\\Teste\\" + fileanexo.nomeAnexo, bytes);
                System.Diagnostics.Process.Start("C:\\Teste\\" + fileanexo.nomeAnexo);
                MessageBox.Show("Abrindo arquivo");
                File.Delete("C:\\Teste\\" + fileanexo.nomeAnexo);
            }
            
        }
        private void TbDescricao_TextChanged(object sender, EventArgs e)
        {
            if (tbDescricao.TextLength <= 300)
                tbResultado.Text = tbDescricao.TextLength.ToString();
            else MessageBox.Show("Maximo de caracteres atingido");
        }

        private void TbTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgAddAnexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
