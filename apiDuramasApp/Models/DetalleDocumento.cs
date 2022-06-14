using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiDuramasApp.Models
{
    public class DetalleDocumento
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int DetalleDocumentoId { get; set; }
        public int DocumentoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Itbis{ get; set; }
        public Decimal Precio { get; set; }
        public Decimal Total { get; set; }
        public bool Activo { get; set; }
    }
}
