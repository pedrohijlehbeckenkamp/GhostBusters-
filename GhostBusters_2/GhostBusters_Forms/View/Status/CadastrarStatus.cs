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
        private StatusModel status;
        public CadastrarStatus()
        {
            InitializeComponent();
            CenterToParent();
        }
        public CadastrarStatus(StatusModel _status)
        {
            InitializeComponent();
            CenterToParent();
            status = _status;
            tbNomeS.Text = status.NomeStatus;
            CbListarPerfil.Text = status.perfil.nomePerfil;
        }

        public bool ValidarStatus()
        {
            Regex validaNomeStatus = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(tbNomeS.Text) || validaNomeStatus.IsMatch(tbNomeS.Text)) {

                tbNomeS.BackColor = Color.Red;
                MessageBox.Show("Erro ao inserir status!");
            }
            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidarStatus())
            {
                new StatusController().Cadastro(GetCadastrarStatus());
                MessageBox.Show("Status cadastrado!");
                this.Close();
            }
            else
            {
                new StatusController().Cadastro(UpDateS());
                this.Close();
            }
        }
        public StatusModel GetCadastrarStatus() => new StatusModel
        {
            NomeStatus = tbNomeS.Text,
            perfil = (Perfil)CbListarPerfil.SelectedItem
        };
        private StatusModel UpDateS() => new StatusModel()
        {
            codigo_status = status.codigo_status,
            NomeStatus = tbNomeS.Text,
            perfil = (Perfil)CbListarPerfil.SelectedItem
        };
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
