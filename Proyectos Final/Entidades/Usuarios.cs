﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Final.Entidades
{
    class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            id = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            NivelUsuario = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
