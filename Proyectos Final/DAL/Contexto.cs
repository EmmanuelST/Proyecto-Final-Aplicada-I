using Proyectos_Final.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Final.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Cargos> Cargo { get; set; }

        public Contexto():base("ConStr")
        {

        }
    }
}
