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
    public partial class rProducto : Form
    {
        public rProducto()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ProductoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            ExistenciatextBox.Text = string.Empty;
            ValorInventariotextBox.Text = string.Empty;
            errorProvider.Clear();
        }
        private Producto LlenaClase()
        {
            Producto productos = new Producto();
            productos.ProductoId = Convert.ToInt32(ProductoIDnumericUpDown.Value);
            productos.Descripcion = DescripciontextBox.Text;
            productos.Costo = Convert.ToInt32(CostotextBox.Text);
            productos.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            productos.ValorInventario = Convert.ToInt32(ValorInventariotextBox.Text);
            return productos;
        }

        private void LlenaCampo(Producto productos)
        {
            ProductoIDnumericUpDown.Value = productos.ProductoId;
            DescripciontextBox.Text = productos.Descripcion;
            ExistenciatextBox.Text = productos.Existencia.ToString();
            CostotextBox.Text = productos.Costo.ToString();
            ValorInventariotextBox.Text = productos.ValorInventario.ToString();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ProductoIDnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            ExistenciatextBox.Clear();
            CostotextBox.Clear();
            ValorInventariotextBox.Clear();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Producto productos = BLL.ProductoBLL.Buscar((int)ProductoIDnumericUpDown.Value);

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
            if (CostotextBox.Text == string.Empty)
            {
                errorProvider.SetError(CostotextBox, "El Campo no puede estar vacio.");
                CostotextBox.Focus();
                paso = false;
            }
            if (ExistenciatextBox.Text == string.Empty)
            {
                errorProvider.SetError(ExistenciatextBox, "El Campo no puede estar vacio.");
                ExistenciatextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarEliminar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (ProductoIDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(ProductoIDnumericUpDown, "Busque un producto y luego eliminelo.");
                ProductoIDnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Producto productos;
            bool paso = false;
            if (!ValidarGuardar())
                return;

            productos = LlenaClase();


            if (ProductoIDnumericUpDown.Value == 0)
                paso = ProductoBLL.Guardar(productos);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductoBLL.Modificar(productos);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!ValidarEliminar())
                return;

            int id;
            int.TryParse(ProductoIDnumericUpDown.Text, out id);

            Limpiar();

            if (ProductoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ProductoIDnumericUpDown, "No se puede eliminar un producto que no existe.");
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Producto productos = new Producto();
            int.TryParse(ProductoIDnumericUpDown.Text, out id);

            Limpiar();

            productos = ProductoBLL.Buscar(id);

            if (productos != null)
            {
                MessageBox.Show("Producto Encontrado.");
                LlenaCampo(productos);
            }
            else
                MessageBox.Show("Producto no encontrado.");
        }

        private void ExistenciatextBox_TextChanged_1(object sender, EventArgs e)
        {
          
            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = Convert.ToString(Convert.ToSingle(CostotextBox.Text) * Convert.ToInt32(ExistenciatextBox.Text));

            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";
        }

        private void CostotextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = Convert.ToString(Convert.ToSingle(CostotextBox.Text) * Convert.ToInt32(ExistenciatextBox.Text));

            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExistenciatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CostotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void RProducto_Load(object sender, EventArgs e)
        {

        }

        private void Descripcionlabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistroDeUbicaciones ru = new RegistroDeUbicaciones();
            ru.ShowDialog();
        }
    }
}
