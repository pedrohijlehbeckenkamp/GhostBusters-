using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Categoria;
using GhostBusters_Forms.View.Status;
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
    public partial class ConfigAdm : Form
    {
        String operacao = "";
        public ConfigAdm()
        {
            InitializeComponent();
        }

        private void ConfigAdm_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            if (operacao == "Categoria")
            {
                var lista = new CategoriaController().FindAll();
                dgVisualizar.DataSource = lista;
            }
            else if (operacao == "Status")
            {
                //var lista = new StatusController().Consultar();
                //dgVisualizar.DataSource = lista;
            }
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            operacao = "Categoria";
            loadDataGrid();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            operacao = "Status";
            dgVisualizar.Columns.Add("Ola", "Ola");
            loadDataGrid();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (operacao == "Categoria")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastrarCategoria();
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                
                menu.Show();
                this.Hide();
            }
            else if (operacao == "Status")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastrarStatus();
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };

                menu.Show();
                this.Hide();
            }
            else if (operacao == "")
            {
                MessageBox.Show("Escolha o tipo de visualizar e depois clique na operação desejada!");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {   

            if (operacao == "Categoria")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastrarCategoria((CategoriaModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };

                menu.Show();
                this.Hide();
            }
            else if (operacao == "Status")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastrarStatus((StatusModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };

                menu.Show();
                this.Hide();
            }
            else if (operacao == "")
            {
                MessageBox.Show("Escolha o tipo de visualizar e depois clique na operação desejada!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;

            if (operacao == "Categoria")
            {
                new CategoriaController().Excluir((CategoriaModel)linha);
                loadDataGrid();
            }
            else if (operacao == "Status")
            {
                
            }
        }
    }
}
