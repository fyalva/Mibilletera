using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miBilletera.Controllers;
using Microsoft.EntityFrameworkCore;

using miBilletera.Models;


namespace miBilletera.Data
{
    public class clienteDB : DbContext
    {
        public clienteDB(DbContextOptions<clienteDB> options) : base(options)
        {
        }

        public DbSet<clienteUsuario> Cliente { get; set; } // Debes utilizar el nombre correcto de la clase ClienteUsuario

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones de modelo (si es necesario)
        }
    }
}