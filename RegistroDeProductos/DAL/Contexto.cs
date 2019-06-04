using RegistroDeProductos.BLL;
using RegistroDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Producto> producto { get; set; }

        public  DbSet<ValorInventario> Consultas { get; set; }
        public DbSet<Ubicaciones> Ubicacion { get; set; }
        public Contexto() : base("ConStr") { }
    }
    
}
