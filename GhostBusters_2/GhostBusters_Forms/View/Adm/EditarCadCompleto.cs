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
        
        public Editar(Usuario usuario)
        {
            InitializeComponent();
        }

        private void BtnTecnicos_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            // GridUsuarios();
        }

        /*private void GridUsuarios() {

            var menu = new Usuario().Codigo_perfil;
            menu.FormClosed += (x, y) =>
        
                   
            

        }*/
    }
}
