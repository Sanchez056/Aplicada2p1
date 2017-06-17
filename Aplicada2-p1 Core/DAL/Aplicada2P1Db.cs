using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicada2p1Core.Entidades;

namespace Aplicada2p1Core.DAL
{
    public class Aplicada2P1Db : DbContext
    {
        public Aplicada2P1Db(DbContextOptions<Aplicada2P1Db> options) : base(options)
        {
        }
        
        public  DbSet<Clientes> Clientes { get; set; }
        
        public DbSet<TelefonosClientes> TelefonosClientes { get; set; }
    }
}
