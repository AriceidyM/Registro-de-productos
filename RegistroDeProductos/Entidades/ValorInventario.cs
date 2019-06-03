using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.Entidades
{
    public class ValorInventario
    {
        [Key]
        public int ProductoID { get; set; }
        public string ValorDeInventario { get; set; }

        public ValorInventario()
        {
            ProductoID = 0;
            ValorDeInventario = string.Empty;
        }
    }
}
