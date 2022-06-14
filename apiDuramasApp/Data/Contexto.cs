using apiDuramasApp.Models;
using Microsoft.EntityFrameworkCore;


namespace apiDuramasApp.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Tools> Tools { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<DetalleDocumento> detalleDocumentos { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
