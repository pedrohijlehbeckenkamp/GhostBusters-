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

namespace GhostBusters_Forms.View.Status
{
    public partial class CadastrarStatus : Form
    {

        private StatusModel status;
        public CadastrarStatus()
        {
            InitializeComponent();
        }

        public CadastrarStatus(StatusModel _status)
        {
            InitializeComponent();
            status = _status;
            tbNome.Text = status.NomeStatus;
        }
    }
}
