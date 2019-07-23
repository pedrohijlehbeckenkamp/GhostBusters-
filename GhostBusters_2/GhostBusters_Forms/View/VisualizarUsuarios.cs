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

namespace GhostBusters_Forms.View
{
    public partial class VisualizarUsuarios : Form
    {
        public VisualizarUsuarios()
        {
            InitializeComponent();
        }

        private void VisualizarUsuarios_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            var lista = new UsuarioController().FindAll();

            dgVisualizar.AutoGenerateColumns = false;
            dgVisualizar.DataSource = lista;
        }

        private void DgVisualizar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;

            var menu = new EditarUsuario((Usuario)linha);
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };
            menu.Show();
            this.Hide();
        }
    }
}
