using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RegistroDeProductos.Resourses.Scripts.Contexto;

namespace RegistroDeProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  LlenaClase()
        {
            

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ProductoIDnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            ExistenciatextBox.Clear();
            CostotextBox.Clear();
            ValorInventariotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
