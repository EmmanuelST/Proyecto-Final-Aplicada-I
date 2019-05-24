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
    public partial class cCargos : Form
    {
        public cCargos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {

                switch (FlitrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = CargosBLL.GetList(p => true);
                        break;

                    case 1://ID
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = CargosBLL.GetList(p => p.CargoId == id);
                        break;

                    case 2://Descripcion
                        listado = CargosBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;

                }
                
            }
            else
            {
                listado = CargosBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }

       
    }
}
