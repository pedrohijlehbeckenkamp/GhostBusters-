﻿using GhostBusters_Forms.Controller;
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
    public partial class Editar : Form
    {
        string dg = "";

        public Editar()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            AlimentarDg();
        }

        private void BtnTecnicos_Click(object sender, EventArgs e)
        {
            dg = "Técnico";
            AlimentarDg();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            dg = "Usuario";
            AlimentarDg();
        }

        private void BtnAdms_Click(object sender, EventArgs e)
        {
            dg = "Admin";
            AlimentarDg();
        }

        private void AlimentarDg()
        {

            if (dg == "Admin")
            {
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = new UsuarioController().FindByUsuario("Admin"); ;
            }
            
            else if (dg == "Usuario")
            {
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = new UsuarioController().FindByUsuario("Usuario");
            }

            else if (dg == "Técnico")
            {
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = new UsuarioController().FindByUsuario("Técnico");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;

            var menu = new EditarUsuario((Usuario)linha);
            menu.FormClosed += (x, y) =>
            {
                this.Show();
                this.AlimentarDg();
            };
            menu.Show();
            this.Hide();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //var linha = dgVisualizar.CurrentRow.DataBoundItem;

            //new UsuarioController().Excluir((Usuario)linha);
            //AlimentarDg();
        }
    }
}