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
        int idImagem = 0;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public AlteraPic()
        {
            InitializeComponent();
        }

        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }

            return null;
        }

        private void AlteraPic_Load(object sender, EventArgs e)
        {
            
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

        private Imagem SalvarImagemBase64(FileInfo file) => new Imagem
        {
           
            nomeImagem = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName))
          
        };

        private void BtnSaveBase_Click(object sender, EventArgs e)
        {
            Imagem image = null;
            if (pictureImagem.ImageLocation != null)
            {
                FileInfo file = new FileInfo(pictureImagem.ImageLocation);
                image = new ImagemController().Cadastro(SalvarImagemBase64(file));

            }
        }


        
    }
}
