using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReyfiBurguer.BLL;
using ReyfiBurguer.DAL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReyfiBurguer.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        private object expression;

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombres = "Reyfi";
            usuarios.NombreUsuario = "reyfiv";
            usuarios.Contraseña = "12345";
            usuarios.ConfirmarContraseña = "12345";
            usuarios.TipoUsuario = "cajero";
            paso = UsuariosBLL.Guardar(usuarios);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombres = "Frandy Mota";
            usuarios.NombreUsuario = "MotaCush";
            usuarios.Contraseña = "12345";
            usuarios.ConfirmarContraseña = "12345";
            usuarios.TipoUsuario = "cajero";
            paso = UsuariosBLL.Modificar(usuarios);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = UsuariosBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 2;
            Usuarios usuario = new Usuarios();
            usuario = UsuariosBLL.Buscar(id);
            Assert.IsNotNull(usuario);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Usuarios, bool>> expression)
        {
            //Contexto contexto = new Contexto();
            //bool paso;
            //List<Usuarios> ListUsuarios = new List<Usuarios>();
            //ListUsuarios = contexto.Usuarios.Where(expression).ToList();
            //Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void IniciarSecionTest()
        {
            
            Usuarios usuarios = new Usuarios();
            usuarios.NombreUsuario = "MotaCush";
            usuarios.Contraseña = "12345";
            usuarios.TipoUsuario = "cajero";
            UsuariosBLL.IniciarSecion("MotaCush", "12345", "cajero");
        }
    }
}