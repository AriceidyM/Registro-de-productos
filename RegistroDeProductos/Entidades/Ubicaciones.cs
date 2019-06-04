using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.Entidades
{
    public class Ubicaciones
    {
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }


        public Ubicaciones()
        {
            ID = 0;
            Descripcion = string.Empty;
        }
    }
}
