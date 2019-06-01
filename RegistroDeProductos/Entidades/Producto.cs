using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string Existencia { get; set; }
        public string Costo { get; set; }
        public string ValoInventario { get; set; }


        public Producto()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = string.Empty;
            Costo = string.Empty;
            ValoInventario = string.Empty;
            
        }
    }
}
