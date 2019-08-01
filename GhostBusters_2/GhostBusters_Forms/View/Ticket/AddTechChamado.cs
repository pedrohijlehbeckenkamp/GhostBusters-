using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.View.Ticket
{
    public partial class AddTechChamado : Form
    {
        private ChamadoModel chamado;
        private Usuario UsuarioLogin;
        public AddTechChamado(ChamadoModel _chamado, Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            chamado = _chamado;
            UsuarioLogin = _usuario;
        }

        private void AddTechChamado_Load(object sender, EventArgs e)
        {
            LoadAddTech();
        }
        private void LoadAddTech()
        {
            cbBoxDisponiveis.DataSource = new UsuarioController().FindbyPerfil("Técnico");
            cbBoxDisponiveis.DisplayMember = "NomeUsuario";
            tbNomeChamado.Text = chamado.Titulo;
            tbNomeChamado.Enabled = false;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {

            var statusAnt = chamado.StatusChamado;
            var statusNew = new StatusController().FindByName("Em atendimento");
            string menssagem = "Add Tech";
            if (chamado.Tech == null)
                new LogController().Cadastro(GetLog(statusAnt, menssagem, statusNew));
            var updateChamado = UpdateTicket(statusNew);
            new ChamadoController().Cadastro(updateChamado);

            this.Close();
        }

        public LogModel GetLog(StatusModel statusAnt, string mensagem, StatusModel statusNew) => new LogModel()
        {
            Observacao = mensagem,
            Data_log = DateTime.Now,
            Usuario = UsuarioLogin.NomeUsuario,
            //Owner = usuarioLogin,
            Chamado = chamado,
            Status_Ant = statusAnt,
            Status_New = statusNew
        };

        private ChamadoModel UpdateTicket(StatusModel statusNew)
        {
            ChamadoModel UpChamado = chamado;
            chamado.Tech = (Usuario)cbBoxDisponiveis.SelectedItem;
            chamado.StatusChamado = statusNew;
            return UpChamado;
        }
    }
}
