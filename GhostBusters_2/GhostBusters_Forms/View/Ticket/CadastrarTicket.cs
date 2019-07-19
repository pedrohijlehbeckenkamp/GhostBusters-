using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
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

namespace GhostBusters_Forms.View.Ticket
{
    public partial class CadastrarTicket : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Usuario usuarioLogin;
        private BindingList<Anexo> listaAnexo = new BindingList<Anexo>();
        public CadastrarTicket(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuarioLogin = _usuario;
        }

        private void CadastrarTicket_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            cbCategoria.DataSource = new CategoriaController().FindAll();
            cbCategoria.DisplayMember = "NomeCategoria";
            //dataGridPedidos.AutoGenerateColumns = false;
            //dataGridPedidos.DataSource = produtoDTOs;
            dgAddAnexo.AutoGenerateColumns = false;
            dgAddAnexo.DataSource = listaAnexo;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChamado();
            this.Close();
        }

        public void SaveChamado()
        {
            //Anexo anexo = null;
           // ChamadoModel chamado;
            new ChamadoController().Cadastro(GetChamado());
            
           // new AnexoController().AddChamado(chamado);
        }

        public ChamadoModel GetChamado() => new ChamadoModel()
        {
            Data_Chamado = DateTime.Now,
            Data_Chamado_finalizado = DateTime.Now.Date,
            Titulo = tbTitulo.Text,
            Descricao = tbDescricao.Text,
            anexos = listaAnexo.ToList(),
            statusModel = new StatusController().FindByName("Aguardando Atendimento"),
            categoria = (CategoriaModel)cbCategoria.SelectedItem,
            Owner = usuarioLogin            
        };
        public Anexo GetAnexo(FileInfo file) => new Anexo()
        {
            nomeAnexo = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName)),
            Extensao= file.Extension
        };
        private void butOpenAnexo_Click(object sender, EventArgs e)
        {
         }

        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }
            return null;
        }
        private void ButAddAnexo_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(AbrirAnexo());
            //var anexo = new AnexoController().CadastroOrUpdate(GetAnexo(file));
            listaAnexo.Add(GetAnexo(file));
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

        private void ButClearAnexo_Click(object sender, EventArgs e)
        {
            var anexoSelecionado = dgAddAnexo.CurrentRow.DataBoundItem;
            var anexo = (Anexo)anexoSelecionado;
            string message = "Deseija excluir esse anexo" + anexo.nomeAnexo;
            const string caption = "Form Closing";
            /*var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,//.YesNo,
                                         MessageBoxIcon.Question);*/
            var resultado = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                listaAnexo.Remove(anexo);

            dgAddAnexo.DataSource = listaAnexo;
           
        }

        private void DgAddAnexo_DoubleClick(object sender, EventArgs e)
        {
            var fileanexo = (Anexo)dgAddAnexo.CurrentRow.DataBoundItem;
            byte[] bytes = Convert.FromBase64String(fileanexo.BaseData);
            File.WriteAllBytes("C:\\GhostBusters\\" + fileanexo.nomeAnexo, bytes);
            System.Diagnostics.Process.Start("C:\\GhostBusters\\" + fileanexo.nomeAnexo);
            MessageBox.Show("Abrindo arquivo");
            File.Delete("C:\\GhostBusters\\" + fileanexo.nomeAnexo);

        }
    }
}
