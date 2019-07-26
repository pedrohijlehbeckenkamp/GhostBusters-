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
            CenterToParent();
            chamado = _chamado;
            usuarioLogin = _usuarioLogin;
        }
        private void AlterarStatus_Load(object sender, EventArgs e)
        {
            LoadAlterarStatus();
        }
        private void LoadAlterarStatus()
        {
            CbStatus.DataSource = new StatusController().FinByStatusPerfil(usuarioLogin.Codigo_perfil);
            CbStatus.DisplayMember = "NomeStatus";
            CbStatus.SelectedIndex = CbStatus.FindStringExact(chamado.Nomestatus);
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            var statusitem = (StatusModel)CbStatus.SelectedItem;
            var statusant = chamado.StatusChamado;
            int cont = 0;
            int cont2 = 0;
            if (chamado.Owner.Codigo_perfil == statusitem.codigo_perfil)
            {
                new StatusController().Cadastro(UpdateNullStatus(statusitem));
                cont++;
            }
            if (chamado.Owner.Codigo_perfil == chamado.StatusChamado.codigo_perfil)
            {
                new StatusController().Cadastro(UpdateNullStatus(chamado.StatusChamado));
                cont2++;
            }
            new LogController().Cadastro(GetLog(statusitem));

            new ChamadoController().Cadastro(UpdateTicket());
           

            if (cont > 0)
                new StatusController().Cadastro(UpdateCodigoPrefilStatus(statusitem));
            if (cont2 > 0)
                new StatusController().Cadastro(UpdateCodigoPrefilStatus(statusant));
            this.Close();
        }

        private StatusModel UpdateNullStatus(StatusModel statusitem)
        {
            StatusModel status = statusitem;
            status.codigo_perfil = null;
            status.perfil = null;
            return status;
        }

        private StatusModel UpdateCodigoPrefilStatus(StatusModel statusitem)
        {
            StatusModel status = statusitem;
            status.codigo_perfil = chamado.Owner.Codigo_perfil;
            status.perfil = chamado.Owner.perfil;
            return status;
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
            Usuario = usuarioLogin.NomeUsuario,
            Chamado = chamado,
            //Owner = usuarioLogin,
            Status_Ant = chamado.StatusChamado,
            Status_New = statusnew
        };
    }
}
