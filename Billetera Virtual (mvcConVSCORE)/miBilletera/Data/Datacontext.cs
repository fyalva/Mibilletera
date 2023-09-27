using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miBilletera.Models;
using Microsoft.EntityFrameworkCore;

namespace miBilletera.Data
{
    public class Datacontext : DbContext    
    {
        public Datacontext(DbContextOptions<Datacontext>options)
        :base(options)
        {
            
        }
        public DbSet <Usuarios>Usuarios {get; set;}
    }
}