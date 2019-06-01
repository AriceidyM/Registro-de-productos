using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.Resourses.Scripts
{
    class Contexto
    {
        public class contexto : DbContext
        {
            public DbSet<ProductoDbDataSet> Productos { get; set; }

            public contexto() : base("ConStr")
            { }
        }
    }
}
