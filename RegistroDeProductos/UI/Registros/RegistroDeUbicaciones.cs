using RegistroDeProductos.BLL;
using RegistroDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeProductos.UI.Registros
{
    public partial class RegistroDeUbicaciones : Form
    {
        public RegistroDeUbicaciones()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            errorProvider.Clear();
        }
        private Ubicaciones LlenaClase()
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            ubicaciones.ID = Convert.ToInt32(IDnumericUpDown.Value);
            ubicaciones.Descripcion = DescripciontextBox.Text;
            return ubicaciones;
        }

        private void LlenaCampo(Ubicaciones ubicaciones)
        {
            IDnumericUpDown.Value = ubicaciones.ID;
            DescripciontextBox.Text = ubicaciones.Descripcion;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Producto productos = BLL.ProductoBLL.Buscar((int)IDnumericUpDown.Value);

            return (productos != null);
        }
        private bool ValidarGuardar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox, "El Campo no puede estar vacio.");
                DescripciontextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ValidarEliminar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (IDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(IDnumericUpDown, "Busque otra ubicacion y luego eliminelo.");
                IDnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }
        private void Gaurdarbutton_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicaciones;
            bool paso = false;
            if (!ValidarGuardar())
                return;

            ubicaciones = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                paso = UbicacionBLL.Guardar(ubicaciones);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UbicacionBLL.Modificar(ubicaciones);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!ValidarEliminar())
                return;

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (UbicacionBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar ubicacion que no existe.");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Ubicaciones ubicaciones = new Ubicaciones();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            ubicaciones = UbicacionBLL.Buscar(id);

            if (ubicaciones != null)
            {
                MessageBox.Show("Producto Encontrado.");
                LlenaCampo(ubicaciones);
            }
            else
                MessageBox.Show("Producto no encontrado.");
        }
    }
}
