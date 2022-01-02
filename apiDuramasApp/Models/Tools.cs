using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiDuramasApp.Models
{
    public class Tools
    {
        [Key]
        public int ToolsId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
    }
}
