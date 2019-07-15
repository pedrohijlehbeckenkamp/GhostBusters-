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
        public ConfigAdm()
        {
            InitializeComponent();
        }

        private void ConfigAdm_Load(object sender, EventArgs e)
        {
            dgVisualizar.ReadOnly = true;
            dgVisualizar.AutoGenerateColumns = false;
        }
    }
}
