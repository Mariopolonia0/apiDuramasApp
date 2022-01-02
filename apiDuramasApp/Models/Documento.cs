using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiDuramasApp.Models
{
    public class Documento
    {
        [Key]
        public int DocumentoId { get; set; }
        public int Nombre { get; set; }
        public int Direccion { get; set; }
        public int NumeroTelefono { get; set; }
        public int TipoDocumento { get; set; }
        public int Fecha { get; set; }
        public int Servicio { get; set; }
        public int PrecioTotal { get; set; }

        [ForeignKey("DocumentoId")]
        List<DetalleDocumento> detalleDocumento { get; set; } = new List<DetalleDocumento>();
    }

    public class DetalleDocumento
    {
        [Key]
        public int DetalleDocumentoId { get; set; }
        public int DocumentoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }
    }
}
