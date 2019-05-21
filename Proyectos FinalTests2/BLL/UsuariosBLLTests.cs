using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyectos_Final.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectos_Final.BLL;
using Proyectos_Final.Entidades;

namespace Proyectos_Final.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = "Prueba";
            usuario.NivelUsuario = 1;
            usuario.FechaIngreso = DateTime.Now;
            usuario.Email = " Prueba@prueba.com";
            usuario.Usuario = "Usuario prueba";
            usuario.Clave = "1234";

            bool paso =UsuariosBLL.Guardar(usuario);

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = 1;
            usuario.Nombre = "Prueba";
            usuario.NivelUsuario = 1;
            usuario.FechaIngreso = DateTime.Now;
            usuario.Email = " Prueba@prueba.com";
            usuario.Usuario = "Usuario prueba";
            usuario.Clave = "1234";

            bool paso = UsuariosBLL.Modificar(usuario);

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}