using ReyfiBurguer.Entidades;
using System.Data.Entity;

namespace ReyfiBurguer.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }

}
