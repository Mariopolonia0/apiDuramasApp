using apiDuramasApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiDuramasApp.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
