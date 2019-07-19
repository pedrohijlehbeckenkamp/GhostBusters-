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
        public AddTechChamado(ChamadoModel _chamado)
        {
            InitializeComponent();
            CenterToParent();
            chamado = _chamado;
        }

        private void AddTechChamado_Load(object sender, EventArgs e)
        {
            cbBoxDisponiveis.DataSource = new UsuarioController().FindbyPerfil("Técnico");
            cbBoxDisponiveis.DisplayMember = "NomeUsuario";
            textBox1.Text = chamado.Titulo;

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {

                /*if (chamado.Tech != null)
                {
                    chamado.Tech = null;
                    new ChamadoController().Cadastro(chamado);
                }*/
                chamado.Tech = (Usuario)cbBoxDisponiveis.SelectedItem;
                new ChamadoController().Cadastro(chamado);
                this.Close();


            }
            catch (Exception ex)
            {
                    
                MessageBox.Show("Eroooooooô " + ex.Message);
            }
        }
    }
}
