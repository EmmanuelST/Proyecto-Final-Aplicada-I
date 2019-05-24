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

namespace Proyectos_Final.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();

            if(CriteriotextBox.Text.Trim().Length > 0)
            {

                switch (FlitrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = UsuariosBLL.GetList(p => true);
                        break;

                    case 1://ID
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = UsuariosBLL.GetList(p => p.UsuarioId == id);
                        break;

                    case 2://Nombre
                        listado = UsuariosBLL.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                        break;

                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();


            }
            else
            {
                listado = UsuariosBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }

        
    }
}
