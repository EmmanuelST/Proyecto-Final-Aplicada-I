using Proyectos_Final.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos_Final.UI
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            CodigonumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            NivelUsuarionumericUpDown.Value = 1;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            FechaIngresodateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
                        
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.id = Convert.ToInt32(CodigonumericUpDown.Value);
            usuario.Nombre = NombretextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.NivelUsuario = Convert.ToInt32(NivelUsuarionumericUpDown.Value);
            usuario.Usuario = UsuariotextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;

            return usuario;
        }


    }
}
