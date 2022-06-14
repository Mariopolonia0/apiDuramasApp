using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace apiDuramasApp.Models
{
    public class Documento
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int DocumentoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefono { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string Servicio { get; set; }
        public decimal PrecioTotal { get; set; }
        public bool Activo { get; set; }
    }
}
