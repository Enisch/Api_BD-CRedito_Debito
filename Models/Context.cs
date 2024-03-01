using ApiComDBCartões.classes;
using Microsoft.EntityFrameworkCore;

namespace ApiComDBCartões.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<CartaoCredito> CartaoCredito { get; set; }
        public virtual DbSet<Conta_debito> Conta_debito { get; set; }

    }
}
