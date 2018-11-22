using ReyfiBurguer.DAL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace ReyfiBurguer.BLL
{
    public class CombosBLL
    {
        public static bool Guardar(Combos combo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Combos.Add(combo) != null)
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

        public static bool Modificar(Combos combo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Combos.Find(combo.ComboId);

                foreach (var item in Anterior.Producto)
                {
                    if (!combo.Producto.Exists(d => d.ProductosDetalleId == item.ProductosDetalleId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in combo.Producto)
                {
                    var estado = item.ProductosDetalleId > 0 ? EntityState.Modified : EntityState.Added;
                    db.Entry(item).State = estado;
                }
                db.Entry(combo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Combos combo = contexto.Combos.Find(id);

                var Anterior = contexto.Combos.Find(combo.ComboId);
                foreach (var item in Anterior.Producto)
                {
                    if (!combo.Producto.Exists(d => d.ProductosDetalleId == item.ProductosDetalleId))
                        contexto.Entry(item).State = EntityState.Deleted;
                }

                contexto.Combos.Remove(combo);

                if (contexto.SaveChanges() > 0)
                {
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

        public static Combos Buscar(int id)
        {
            Contexto db = new Contexto();
            Combos combo = new Combos();
            try
            {
                combo = db.Combos.Find(id);
                if(combo==null)
                {
                    db.Dispose();
                    return combo;
                }
                    
                combo.Producto.Count();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return combo;
        }

        public static List<Combos> GetList(Expression<Func<Combos, bool>> expression)
        {
            List<Combos> combo = new List<Combos>();
            Contexto contexto = new Contexto();
            try
            {
                combo = contexto.Combos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return combo;
        }
    }
}
