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
using Proyectos_Final.BLL;

namespace Proyectos_Final.UI
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            
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

            usuario.UsuarioId = Convert.ToInt32(CodigonumericUpDown.Value);
            usuario.Nombre = NombretextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.NivelUsuario = Convert.ToInt32(NivelUsuarionumericUpDown.Value);
            usuario.Usuario = UsuariotextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;


            return usuario;
        }

        

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();


            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox, "El campo de Email no puede estar vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                errorProvider.SetError(UsuariotextBox, "El campo de Usuario no puede estar vacio");
                paso = false;

            }

            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider.SetError(ClavetextBox, "El Campo de Clave no puede estar vacio");
                paso = false;
            }



            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)CodigonumericUpDown.Value);
            return (usuario != null);
        }

      

        private void LlenarCampos(Usuarios usuario)
        {
            CodigonumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.Nombre;
            EmailtextBox.Text = usuario.Email;
            NivelUsuarionumericUpDown.Value = usuario.NivelUsuario;
            UsuariotextBox.Text = usuario.Usuario;
            ClavetextBox.Text = usuario.Clave;
            FechaIngresodateTimePicker.Value = usuario.FechaIngreso;
        }

        

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id = Convert.ToInt32(CodigonumericUpDown.Value);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                errorProvider.SetError(CodigonumericUpDown, "No se puede eliminar este Usuario");

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            id = Convert.ToInt32(CodigonumericUpDown.Value);

            Limpiar();
            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenarCampos(usuario);
            }
            else
            {
                MessageBox.Show("Usuario No Encontrado");
            }

        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenarClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (CodigonumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
    }

        
    
}
