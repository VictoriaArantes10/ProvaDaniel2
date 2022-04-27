using Projeto.Models;
using System.Data.Entity;

namespace Projeto.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Projeto")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}