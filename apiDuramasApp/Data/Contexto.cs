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
        public DbSet<Tools> Tools { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<DetalleDocumento> detalleDocumentos { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
