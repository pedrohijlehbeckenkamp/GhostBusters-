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

namespace GhostBusters_Forms.View.Adm
{
    public partial class AlterarStatus : Form
    {
        private ChamadoModel chamado;
        private Usuario usuarioLogin;
        public AlterarStatus(Usuario _usuarioLogin, ChamadoModel _chamado)
        {
            InitializeComponent();
            chamado = _chamado;
            usuarioLogin = _usuarioLogin;
        }
        private void AlterarStatus_Load(object sender, EventArgs e)
        {
            LoadAlterarStatus();
        }
        private void LoadAlterarStatus()
        {
            CbStatus.DataSource = new StatusController().FindAll();
            CbStatus.DisplayMember = "nomeStatus";
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            var statusitem = (StatusModel)CbStatus.SelectedItem;
            new ChamadoController().Cadastro(UpdateTicket());
            new LogController().Cadastro(GetLog(statusitem));
        }
        private ChamadoModel UpdateTicket()
        {
            ChamadoModel UpChamado = chamado;
            UpChamado.StatusChamado = (StatusModel)CbStatus.SelectedItem;
            return UpChamado;
        }
        public LogModel GetLog(StatusModel statusnew) => new LogModel()
        {
            Observacao = tbObservacao.Text,
            Data_log = DateTime.Now,
            Chamado = chamado,
            Owner = usuarioLogin,
            Status_Ant = chamado.StatusChamado,
            Status_New = statusnew
        };
    }
}
