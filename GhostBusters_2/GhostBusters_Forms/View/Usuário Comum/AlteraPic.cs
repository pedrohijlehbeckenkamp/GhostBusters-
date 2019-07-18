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

namespace GhostBusters_Forms.View.Usuário_Comum
{
    public partial class AlteraPic : Form
    {
      
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private Usuario usuario;
        public AlteraPic(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;

        }

        public void AlteraPic_Load(object sender, EventArgs e)
        {
            if (usuario.Foto != null)
            {
                byte[] bytes = Convert.FromBase64String(usuario.Foto.BaseData);
                using (MemoryStream memory = new MemoryStream(bytes))
                {
                    pictureImagem.Image = Image.FromStream(memory); 

               }

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

      
      
   
        private void BtnOpenBase_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }

        private void AbrirImagem()
        {
            var fileDialog = GetOpenFileDialog();
            if (fileDialog != null)
            {
                string location = fileDialog.FileName;
                pictureImagem.ImageLocation = location;
                pictureImagem.Load();

            }
        }

        private ImagemModel SalvarImagemBase64(FileInfo file) => new ImagemModel
        {
            codigo_imagem = usuario.Foto.codigo_imagem,
            nomeImagem = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName))
          
        };

        private void BtnSaveBase_Click(object sender, EventArgs e)
        {
           
            if (pictureImagem.ImageLocation != null)
            {
                FileInfo file = new FileInfo(pictureImagem.ImageLocation);
                new ImagemController().Cadastro(SalvarImagemBase64(file));
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var imagem = new ImagemController().BuscaNome("default.png");
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            using (MemoryStream ms = new MemoryStream(bytes))
            {

                pictureImagem.Image = Image.FromStream(ms);
            }


        }
    }
}
