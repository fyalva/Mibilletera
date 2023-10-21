using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miBilletera.Models;
using Microsoft.EntityFrameworkCore;

namespace miBilletera.Data
{
    public class ClienteDB : DbContext
    {
        public ClienteDB(DbContextOptions<ClienteDB> options) : base(options)
        {
        }
     
         public DbSet<ClienteUsuario> Clientes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones de modelo (si es necesario)
        }
    }
}
