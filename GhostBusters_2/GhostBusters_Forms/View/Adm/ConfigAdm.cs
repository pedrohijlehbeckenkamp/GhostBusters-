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

        private void loadDataGrid()
        {
            if (operacao == "Categoria")
            {
                //dgVisualizar.DataSource = new Controller().Consultar();
            }
            else if (operacao == "Status")
            {
                //dgVisualizar.DataSource = new Controller().Consultar();
            }
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            operacao = "Categoria";
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            operacao = "Status";
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

            if (linha != null)
            {
                //new MetodoPagamentoController().Excluir((MetodoPagamento)linha);
                //loadDataGrid();
            }
            else
            {
                MessageBox.Show("Selecione uma " + operacao + "!");
            }
        }
    }
}
