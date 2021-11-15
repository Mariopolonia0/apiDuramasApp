using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiDuramasApp.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
    }
}
