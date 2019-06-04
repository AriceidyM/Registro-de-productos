using RegistroDeProductos.Entidades;
using RegistroDeProductos.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeProductos.BLL
{
    class UbicacionBLL
    {
        public static Ubicaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ubicaciones Ubicacion = new Ubicaciones();
            try
            {
                Ubicacion = contexto.Ubicacion.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return Ubicacion;
        }


        public static bool Guardar(Ubicaciones Ubicacion)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Add(Ubicacion) != null)
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

        public static bool Modificar(Ubicaciones Ubicacion)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Ubicacion).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Ubicacion.Find(id);
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
    }
}
