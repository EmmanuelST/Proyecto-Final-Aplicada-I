using Proyectos_Final.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.MdiParent = this;
            frmRegistroUsuario.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
