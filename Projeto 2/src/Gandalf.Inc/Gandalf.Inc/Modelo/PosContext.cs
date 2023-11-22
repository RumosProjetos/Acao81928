using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class PosContext : DbContext
    {
        private string caminho;

        public PosContext()
        {
            string pasta = @"c:\temp";
            string database = "Gandalf.db";
            caminho = System.IO.Path.Combine(pasta, database);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={caminho}");

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
