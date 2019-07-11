using GhostBusters_Forms.View.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.Adm
{
    public partial class TelaPrincipalAdm : Form
    {
        public TelaPrincipalAdm()
        {
            InitializeComponent();
        }

        private void TelaPrincipalAdm_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewTicket_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarTicket();
            menu.FormClosed += (x, y) =>
            {
                this.Show();
            };

            menu.Show();
            this.Hide();
        }
    }
}
