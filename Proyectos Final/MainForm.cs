﻿using Proyectos_Final.UI;
using Proyectos_Final.UI.Consultas;
using Proyectos_Final.UI.Registro;
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
            rUsuario frmRegistroUsuario = new rUsuario();
            frmRegistroUsuario.MdiParent = this;
            frmRegistroUsuario.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargo rCargo = new rCargo();
            rCargo.MdiParent = this;
            rCargo.Show();
        }

        private void CosultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cUsuarios = new cUsuarios();
            cUsuarios.MdiParent = this;
            cUsuarios.Show();
        }

        private void ConsultarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCargos cCargos = new cCargos();
            cCargos.MdiParent = this;
            cCargos.Show();
        }
    }
}
