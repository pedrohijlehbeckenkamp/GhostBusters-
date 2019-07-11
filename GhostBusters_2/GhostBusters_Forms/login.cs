using System;
using GhostBusters_Infra;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Adm;

namespace GhostBusters_Forms
{
    public partial class Login : Form
    {
        CadastroUsuario objLogin = new  CadastroUsuario();

        public Login()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var menu = new CadastroUsuario();
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };

            menu.Show();
            this.Hide();
        }


        private void TbUsuario_TextChanged(object sender, EventArgs e)
        { //validar
            //GhostBusters_Infra.Repository.BaseRepository();
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        { // validar

        }

        private void Login_Load(object sender, EventArgs e)
        {
            HabilitarCampos();

        }


        public void HabilitarCampos() {

            tbSenha.Enabled = true;
            tbUsuario.Enabled = true;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var menu = new TelaPrincipalAdm();

            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };

            menu.Show();
            this.Hide();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
