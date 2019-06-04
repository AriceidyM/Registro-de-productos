namespace RegistroDeProductos.UI.Registros
{
    partial class rProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductoIDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Existencialabel = new System.Windows.Forms.Label();
            this.Costolabel = new System.Windows.Forms.Label();
            this.ValorInventariolabel = new System.Windows.Forms.Label();
            this.ProductoIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.CostotextBox = new System.Windows.Forms.TextBox();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ubicacionlabel = new System.Windows.Forms.Label();
            this.UbicacioncomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoIDlabel
            // 
            this.ProductoIDlabel.AutoSize = true;
            this.ProductoIDlabel.Location = new System.Drawing.Point(12, 28);
            this.ProductoIDlabel.Name = "ProductoIDlabel";
            this.ProductoIDlabel.Size = new System.Drawing.Size(61, 13);
            this.ProductoIDlabel.TabIndex = 0;
            this.ProductoIDlabel.Text = "ProductoID";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(12, 63);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion";
            this.Descripcionlabel.Click += new System.EventHandler(this.Descripcionlabel_Click);
            // 
            // Existencialabel
            // 
            this.Existencialabel.AutoSize = true;
            this.Existencialabel.Location = new System.Drawing.Point(12, 101);
            this.Existencialabel.Name = "Existencialabel";
            this.Existencialabel.Size = new System.Drawing.Size(55, 13);
            this.Existencialabel.TabIndex = 2;
            this.Existencialabel.Text = "Existencia";
            // 
            // Costolabel
            // 
            this.Costolabel.AutoSize = true;
            this.Costolabel.Location = new System.Drawing.Point(12, 137);
            this.Costolabel.Name = "Costolabel";
            this.Costolabel.Size = new System.Drawing.Size(34, 13);
            this.Costolabel.TabIndex = 3;
            this.Costolabel.Text = "Costo";
            // 
            // ValorInventariolabel
            // 
            this.ValorInventariolabel.AutoSize = true;
            this.ValorInventariolabel.Location = new System.Drawing.Point(12, 167);
            this.ValorInventariolabel.Name = "ValorInventariolabel";
            this.ValorInventariolabel.Size = new System.Drawing.Size(78, 13);
            this.ValorInventariolabel.TabIndex = 4;
            this.ValorInventariolabel.Text = "ValorInventario";
            // 
            // ProductoIDnumericUpDown
            // 
            this.ProductoIDnumericUpDown.Location = new System.Drawing.Point(111, 28);
            this.ProductoIDnumericUpDown.Name = "ProductoIDnumericUpDown";
            this.ProductoIDnumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.ProductoIDnumericUpDown.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(111, 63);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 6;
            this.DescripciontextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(111, 101);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(100, 20);
            this.ExistenciatextBox.TabIndex = 7;
            this.ExistenciatextBox.TextChanged += new System.EventHandler(this.ExistenciatextBox_TextChanged_1);
            this.ExistenciatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciatextBox_KeyPress);
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(111, 137);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.Size = new System.Drawing.Size(100, 20);
            this.CostotextBox.TabIndex = 8;
            this.CostotextBox.TextChanged += new System.EventHandler(this.CostotextBox_TextChanged_1);
            this.CostotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostotextBox_KeyPress);
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Location = new System.Drawing.Point(111, 167);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.ReadOnly = true;
            this.ValorInventariotextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventariotextBox.TabIndex = 9;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroDeProductos.Properties.Resources.Start_Menu_Search_icon;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(227, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 35);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroDeProductos.Properties.Resources.new_file_icon;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 240);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroDeProductos.Properties.Resources.Save_icon;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(121, 240);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroDeProductos.Properties.Resources.delete_icon;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(227, 240);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ubicacionlabel
            // 
            this.Ubicacionlabel.AutoSize = true;
            this.Ubicacionlabel.Location = new System.Drawing.Point(12, 201);
            this.Ubicacionlabel.Name = "Ubicacionlabel";
            this.Ubicacionlabel.Size = new System.Drawing.Size(55, 13);
            this.Ubicacionlabel.TabIndex = 15;
            this.Ubicacionlabel.Text = "Ubicacion";
            // 
            // UbicacioncomboBox
            // 
            this.UbicacioncomboBox.FormattingEnabled = true;
            this.UbicacioncomboBox.Location = new System.Drawing.Point(111, 201);
            this.UbicacioncomboBox.Name = "UbicacioncomboBox";
            this.UbicacioncomboBox.Size = new System.Drawing.Size(100, 21);
            this.UbicacioncomboBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rProducto
            // 
            this.ClientSize = new System.Drawing.Size(310, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UbicacioncomboBox);
            this.Controls.Add(this.Ubicacionlabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.CostotextBox);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ProductoIDnumericUpDown);
            this.Controls.Add(this.ValorInventariolabel);
            this.Controls.Add(this.Costolabel);
            this.Controls.Add(this.Existencialabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.ProductoIDlabel);
            this.Name = "rProducto";
            this.Text = "Registro producto";
            this.Load += new System.EventHandler(this.RProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
             private System.Windows.Forms.Label ProductoIDlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Existencialabel;
        private System.Windows.Forms.Label Costolabel;
        private System.Windows.Forms.Label ValorInventariolabel;
        private System.Windows.Forms.NumericUpDown ProductoIDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.TextBox CostotextBox;
        private System.Windows.Forms.TextBox ValorInventariotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox UbicacioncomboBox;
        private System.Windows.Forms.Label Ubicacionlabel;
        private System.Windows.Forms.Button button1;
    }
}