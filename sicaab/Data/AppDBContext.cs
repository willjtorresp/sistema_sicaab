using sicaab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sicaab.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection") { 
        }
        public DbSet<Articulos> Articulo { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
    }
}