using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyectos_Final.Entidades
{
    public class Cargos
    {

        [Key]
        public int CargoId { get; set; }
        public string Descripción { get; set; }

        public Cargos()
        {
            CargoId = 0;
            Descripción = string.Empty;
        }

        public Cargos(int id,string descripción)
        {
            this.CargoId = id;
            this.Descripción = descripción;
        }
    }
}
