using RegistroDeProductos.Entidades;
using RegistroDeProductos.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.BLL
{
    class ProductoBLL
    {
        public static bool Guardar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.producto.Add(producto) != null)
                    paso = db.SaveChanges() > 0;
                ValorInventario inventario = ValorInventarioBLL.Buscar(1);

                inventario.ValorDeInventario += producto.ValorInventario;

                ValorInventarioBLL.Modificar(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Modificar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var buscar = db.producto.Find(producto.ProductoId);
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.producto.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Producto Buscar(int id)
        {
            Contexto db = new Contexto();
            Producto producto = new Producto();

            try
            {
                producto = db.producto.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;
        }

        public static List<Producto> GetList(Expression<Func<Producto, bool>> producto)
        {
            List<Producto> Lista = new List<Producto>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.producto.Where(producto).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
