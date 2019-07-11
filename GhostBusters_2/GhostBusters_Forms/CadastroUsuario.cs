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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms
{
    public partial class CadastroUsuario : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public CadastroUsuario()
        {
            InitializeComponent();
            CenterToParent();
        }



        private void ButSave_Click(object sender, EventArgs e)
        {
           if (Valida())
           {
               // new UsuarioController().Cadastro(GetUsuario());
                MessageBox.Show("É nois");
           }
           
        }

        public Usuario GetUsuario() => new Usuario
        {
            NomeUsuario = tbNome.Text,
            Email = tbEmail.Text,
            Senha = tbSenha.Text,
            perfil = new PerfilController().BuscaNome(labelUsuario.Text)
        };

        public bool Valida()
        {
            int cont = 0;
            Regex validaNome = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(tbNome.Text) || validaNome.IsMatch(tbNome.Text))
            {
                tbNome.BackColor = Color.Red;
                // MessageBox.Show("Erro nome");
                //return false;
                cont++;
            }else
            {
                tbNome.BackColor = Color.White;
            }

            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");//
            if (!validaEmail.IsMatch(tbEmail.Text) || string.IsNullOrEmpty(tbEmail.Text) || tbConfirmaEmail.Text != tbEmail.Text)
            {
                tbEmail.BackColor = Color.Red;
                tbConfirmaEmail.BackColor = Color.Red;
               // MessageBox.Show("email invalido");
                cont++;
            }
            else
            {
                tbEmail.BackColor = Color.White;
                tbConfirmeSenha.BackColor = Color.AliceBlue;
                // MessageBox.Show("email valido");
            }

            if(string.IsNullOrEmpty(tbSenha.Text) || string.IsNullOrEmpty(tbConfirmeSenha.Text) || tbSenha.Text != tbConfirmeSenha.Text)
            {
                tbConfirmeSenha.BackColor = Color.Red;
                tbSenha.BackColor = Color.Red;
                cont++;
            }
            else
            {
                tbConfirmeSenha.BackColor = Color.White;
                tbSenha.BackColor = Color.White;
            }
            
            if (cont > 0) 
            {
                return false;
            }
            return true;
        }
        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }

            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
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
            //Imagem image = new Imagem();
            nomeImagem = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName))
            //base64Repository.CreateOrUpdate(image);
            //pictureBoxBase64.Image.Dispose();
            //pictureBoxBase64.Image = null;
        };

        private void Salvar_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(pictureImagem.ImageLocation);
           // new ImagemController().Cadastro(SalvarImagemBase64(file));
            pictureImagem.Dispose();
        }



        private void TbNome_TextChanged(object sender, EventArgs e)
        {
          //  tbNome.PasswordChar = '*';
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = '*';
        }

        private void BtnNew_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = tbSenha.Text;
            textBox1.Text = "";
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
