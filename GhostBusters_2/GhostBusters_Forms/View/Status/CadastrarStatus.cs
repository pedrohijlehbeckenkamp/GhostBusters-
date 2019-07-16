using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.View.Status
{
    public partial class CadastrarStatus : Form
    {
       // private StatusModel status;
        public CadastrarStatus()
        {
            InitializeComponent();
            CenterToParent();
        }
        public StatusModel GetCadastrarStatus() => new StatusModel
        {
           NomeStatus = tbNome.Text,
           perfil = (Perfil)CbListarPerfil.SelectedItem
        };

        public bool ValidarStatus()
        {
            int cont = 0;
            Regex validaNomeStatus = new Regex(@"[0-9]");
            if(string.IsNullOrEmpty(tbNome.Text) || validaNomeStatus.IsMatch(tbNome.Text)){

                tbNome.BackColor = Color.Red;
                MessageBox.Show("Erro ao inserir status!");
                cont++;
            }

            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidarStatus())
            {

                new StatusController().Cadastro(GetCadastrarStatus());
            }
            else
            {

                new StatusController().Cadastro(UpDateS());
            }

            MessageBox.Show("Status cadastrado!");
            this.Close();
        }

        private object UpDateS()
        {
            return false;
        }

        private object Cadastrar()
        {
            throw new NotImplementedException();
        }

        private void CadastrarStatus_Load(object sender, EventArgs e)
        {
            MostrarPerfil();
            CbListarPerfil.SelectedItem = new PerfilController().FindAll();
        }

        private void MostrarPerfil()
        {
            CbListarPerfil.DataSource = new PerfilController().FindAll();
            CbListarPerfil.DisplayMember = "nomePerfil";
        }
    }
}
