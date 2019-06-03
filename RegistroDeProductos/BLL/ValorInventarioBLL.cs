using RegistroDeProductos.Entidades;
using RegistroDeProductos.Resourses.Scripts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.BLL
{
    class ValorInventarioBLL
    {
        public static ValorInventario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            ValorInventario inventario = new ValorInventario();
            try
            {
                inventario = contexto.Consultas.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return inventario;
        }


        public static bool Guardar(ValorInventario inventario)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Consultas.Add(inventario) != null)
                {
                    paso = contexto.SaveChanges() > 0;

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(ValorInventario inventario)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(inventario).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static ValorInventario Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            ValorInventario inventario = new ValorInventario();
            try
            {
                inventario = contexto.Consultas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return inventario;
        }
    }
}
