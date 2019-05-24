using Proyectos_Final.BLL;
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

namespace Proyectos_Final.UI.Registro
{
    public partial class rCargo : Form
    {
        public rCargo()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cargos cargo = new Cargos();
            id = Convert.ToInt32(IdCargonumericUpDown.Value);

            Limpiar();
            cargo = CargosBLL.Buscar(id);

            if (cargo != null)
            {
                //MessageBox.Show("Persona Encontrada");
                LlenarCampos(cargo);
            }
            else
            {
                MessageBox.Show("Cargo No Encontrado");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cargos cargo = new Cargos();
            bool paso = false;

            if (!Validar())
                return;

            cargo = LlenarClase();

            if (IdCargonumericUpDown.Value == 0)
                paso = CargosBLL.Guardar(cargo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cargo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(cargo);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Limpiar()
        {
            IdCargonumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        private Cargos LlenarClase()
        {
            Cargos cargo = new Cargos();

            cargo.CargoId = (int)IdCargonumericUpDown.Value;
            cargo.Descripcion = DescripciontextBox.Text;

            return cargo;
        }

        private void LlenarCampos(Cargos cargo)
        {
            IdCargonumericUpDown.Value = cargo.CargoId;
            DescripciontextBox.Text = cargo.Descripcion;
        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar vacio");
                paso = false;
            }
            
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos cargo = CargosBLL.Buscar((int)IdCargonumericUpDown.Value);
            return (cargo != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int id = Convert.ToInt32(IdCargonumericUpDown.Value);

            Limpiar();

            if (CargosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                errorProvider.SetError(IdCargonumericUpDown, "No se puede eliminar este Usuario");

        }
    }
}
