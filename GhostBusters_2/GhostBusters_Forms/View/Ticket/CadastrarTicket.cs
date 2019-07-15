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
        public CadastrarTicket(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuarioLogin = _usuario;
        }

        private void CadastrarTicket_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChamado();
        }

        public void SaveChamado()
        {
            Anexo anexo = null;
            FileInfo file = new FileInfo(textNomeAnexo.Text);
            anexo = new AnexoController().CadastroOrUpdate(GetAnexo(file));

        }

        public ChamadoModel GetChamado() => new ChamadoModel()
        {
            Data_Chamado = DateTime.Now,
            Titulo = tbTitulo.Text,
            Descricao = tbDescricao.Text,
            perfil = usuarioLogin.perfil,
            categoria = (CategoriaModel)cbCategoria.SelectedItem,
            
        };
        public Anexo GetAnexo(FileInfo file) => new Anexo()
        {
            nomeAnexo = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName)),
            Extensao= file.Extension
        };
        private void butOpenAnexo_Click(object sender, EventArgs e)
        {
            if (textNomeAnexo.Text != null)
            {
                System.Diagnostics.Process.Start(textNomeAnexo.Text);
            }    
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
            AbrirAnexo();
        }
        private void AbrirAnexo()
        {
            var fileDialog = GetOpenFileDialog();
            if (fileDialog != null)
            {
                string location = fileDialog.FileName;
               // FileInfo file = new FileInfo(location);
                textNomeAnexo.Text = location;
            }
        }

        private void ButClearAnexo_Click(object sender, EventArgs e)
        {
            textNomeAnexo.Text = "";
        }
    }
}
