using ReyfiBurguer.DAL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ReyfiBurguer.BLL
{
    public class VentasBLL
    {
        public static bool Guardar(Ventas ventas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ventas.Add(ventas) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static Ventas Buscar(int id)
        {
            Contexto db = new Contexto();
            Ventas venta = new Ventas();
            try
            {
                venta = db.Ventas.Find(id);
                if (venta == null)
                {
                    db.Dispose();
                    return venta;
                }

                venta.DetalleProducto.Count();
                venta.DetalleCombo.Count();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return venta;
        }

        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> expression)
        {
            List<Ventas> venta = new List<Ventas>();
            Contexto contexto = new Contexto();
            try
            {
                venta = contexto.Ventas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return venta;
        }
    }
}
