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
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            LoadImagem();
            CbListarPerfil.DataSource = new PerfilController().FindAll();
            CbListarPerfil.DisplayMember = "nomePerfil";
            lbEmailErro.Visible = false;
            lbErroConfEmail.Visible = false;
            lbNomeErro.Visible = false;
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                MessageBox.Show("UHUL");
                //ImagemModel image = null;

                //FileInfo file = new FileInfo(pictureImagem.ImageLocation);
                //image = new ImagemController().Cadastro(SalvarImagemBase64(file));

                //new UsuarioController().Cadastro(GetUsuario(image));
                //MessageBox.Show("Casdastro feito com sucesso");
               // this.Close();
            }
        }

        public Usuario GetUsuario(ImagemModel imagem) => new Usuario
        {
            NomeUsuario = tbNome.Text,
            Email = tbEmail.Text,
            Senha = tbSenha.Text,
            perfil = new PerfilController().BuscaNome(CbListarPerfil.Text),
            Foto = imagem
        };

        public bool Valida()
        {
            int cont = 0;
            if (!Validacoes.ValidaCamponull(tbNome.Text))
            {
                if (Validacoes.ValidaNome(tbNome.Text))
                {
                    lbNomeErro.BackColor = Color.Red;
                    lbNomeErro.Visible = true;
                    lbNomeErro.Text = "Nome Invalido";
                    cont++;
                }
                else
                {
                    lbNomeErro.BackColor = Color.White;
                    lbNomeErro.Visible = false;
                }
            }
            else
            {
                lbNomeErro.Visible = true;
                lbNomeErro.Text = "Nome Invalido";
                cont++;
            }

            if (!Validacoes.ValidaCamponull(tbEmail.Text))
            {
                if (Validacoes.ValidaEmail(tbEmail.Text))
                {
                    tbEmail.BackColor = Color.Red;
                    lbEmailErro.Visible = true;
                    lbEmailErro.Text = "Email invalido";
                    cont++;
                }
                else
                {
                    tbEmail.BackColor = Color.White;
                    lbEmailErro.Visible = false;
                }
            }else
            {
                tbEmail.BackColor = Color.Red;
                lbEmailErro.Visible = true;
                lbEmailErro.Text = "Campo null";
                cont++;
            }

            if (!Validacoes.ValidaCamponull(tbConfirmaEmail.Text))
            {
                if (Validacoes.ValidaConfirmaEmail(tbEmail.Text, tbConfirmaEmail.Text))
                {
                    tbConfirmaEmail.BackColor = Color.Red;
                    lbErroConfEmail.Visible = true;
                    lbErroConfEmail.Text = "Email Difrentes";
                    cont++;
                }
                else
                {
                    tbConfirmaEmail.BackColor = Color.White;
                    lbErroConfEmail.Visible = false;
                }
            }
            else
            {
                tbConfirmaEmail.BackColor = Color.Red;
                lbErroConfEmail.Visible = true;
                lbErroConfEmail.Text = "Campo null";
                cont++;
            }
            

            if (cont > 0)
            {
                return false;
            }
            return true;
            //int cont = 0;
            //Regex validaNome = new Regex(@"[0-9]");
            //if (string.IsNullOrEmpty(tbNome.Text) || validaNome.IsMatch(tbNome.Text))
            //{
            //    tbNome.BackColor = Color.Red;
            //    MessageBox.Show("Erro nome");
            //    //return false;
            //    cont++;
            //}else
            //{
            //    tbNome.BackColor = Color.White;
            //}

            //if(string.IsNullOrEmpty(tbSenha.Text) || string.IsNullOrEmpty(tbConfirmeSenha.Text) || tbSenha.Text != tbConfirmeSenha.Text || tbSenha.Text.Length <6)
            //{
            //    tbConfirmeSenha.BackColor = Color.Red;
            //    tbSenha.BackColor = Color.Red;
            //    cont++;
            //}
            //else
            //{
            //    tbConfirmeSenha.BackColor = Color.White;
            //    tbSenha.BackColor = Color.White;
            //}

            //if (cont > 0)
            //{
            //    return false;
            //}
            //return true;
        }
        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }

            return null;
        }

        private void BtnAbrirImagem_Click(object sender, EventArgs e)
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
            //Imagem image = new Imagem();
            nomeImagem = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName))
            //base64Repository.CreateOrUpdate(image);
            //pictureBoxBase64.Image.Dispose();
            //pictureBoxBase64.Image = null;
        };



        private void LoadImagem()
        {
            var imagem = new ImagemController().BuscaNome("default.png");
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            File.WriteAllBytes("C:\\Teste\\" + imagem.nomeImagem, bytes);
            pictureImagem.ImageLocation = ("C:\\Teste\\" + imagem.nomeImagem);

            // using (MemoryStream ms = new MemoryStream(bytes))
            // {
            //  pictureImagem.Image = Image.FromStream(ms);
            //}  
        }
        private void ClearImagem_Click(object sender, EventArgs e)
        {
            LoadImagem();//Recarrega imagem primaria
        }

        private void BtVisSenha_MouseEnter(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
            tbConfirmeSenha.PasswordChar = tbConfirmeSenha.PasswordChar == char.MinValue ? tbConfirmeSenha.PasswordChar = '*' : char.MinValue;
        }

        private void BtVisSenha_MouseLeave(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
            tbConfirmeSenha.PasswordChar = tbConfirmeSenha.PasswordChar == char.MinValue ? tbConfirmeSenha.PasswordChar = '*' : char.MinValue;
        }
    }
}
