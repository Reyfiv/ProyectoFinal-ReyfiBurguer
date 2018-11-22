using ReyfiBurguer.Entidades;
using System.Data.Entity;

namespace ReyfiBurguer.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Combos> Combos { get; set; }
      

        public Contexto() : base("ConStr")
        {

        }
    }

}
