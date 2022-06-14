using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiDuramasApp.Models
{
    public class Tools
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int ToolsId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public bool Activo { get; set; }
    }
}
