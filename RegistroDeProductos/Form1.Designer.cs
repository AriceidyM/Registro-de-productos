namespace RegistroDeProductos
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProductoIDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Existencialabel = new System.Windows.Forms.Label();
            this.Costolabel = new System.Windows.Forms.Label();
            this.ValorInventariolabel = new System.Windows.Forms.Label();
            this.ProductoIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.CostotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoIDlabel
            // 
            this.ProductoIDlabel.AutoSize = true;
            this.ProductoIDlabel.Location = new System.Drawing.Point(22, 19);
            this.ProductoIDlabel.Name = "ProductoIDlabel";
            this.ProductoIDlabel.Size = new System.Drawing.Size(61, 13);
            this.ProductoIDlabel.TabIndex = 0;
            this.ProductoIDlabel.Text = "ProductoID";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(22, 59);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // Existencialabel
            // 
            this.Existencialabel.AutoSize = true;
            this.Existencialabel.Location = new System.Drawing.Point(22, 103);
            this.Existencialabel.Name = "Existencialabel";
            this.Existencialabel.Size = new System.Drawing.Size(55, 13);
            this.Existencialabel.TabIndex = 2;
            this.Existencialabel.Text = "Existencia";
            // 
            // Costolabel
            // 
            this.Costolabel.AutoSize = true;
            this.Costolabel.Location = new System.Drawing.Point(22, 140);
            this.Costolabel.Name = "Costolabel";
            this.Costolabel.Size = new System.Drawing.Size(34, 13);
            this.Costolabel.TabIndex = 3;
            this.Costolabel.Text = "Costo";
            // 
            // ValorInventariolabel
            // 
            this.ValorInventariolabel.AutoSize = true;
            this.ValorInventariolabel.Location = new System.Drawing.Point(22, 177);
            this.ValorInventariolabel.Name = "ValorInventariolabel";
            this.ValorInventariolabel.Size = new System.Drawing.Size(78, 13);
            this.ValorInventariolabel.TabIndex = 4;
            this.ValorInventariolabel.Text = "ValorInventario";
            // 
            // ProductoIDnumericUpDown
            // 
            this.ProductoIDnumericUpDown.Location = new System.Drawing.Point(121, 19);
            this.ProductoIDnumericUpDown.Name = "ProductoIDnumericUpDown";
            this.ProductoIDnumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.ProductoIDnumericUpDown.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(121, 59);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 6;
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Location = new System.Drawing.Point(121, 177);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventariotextBox.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(95, 289);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroDeProductos.Properties.Resources.Start_Menu_Search_icon;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(225, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 34);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroDeProductos.Properties.Resources.delete_icon;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(221, 229);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroDeProductos.Properties.Resources.Save_icon;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(121, 229);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroDeProductos.Properties.Resources.new_file_icon;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(25, 229);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(121, 103);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(100, 20);
            this.ExistenciatextBox.TabIndex = 13;
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(121, 140);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.Size = new System.Drawing.Size(100, 20);
            this.CostotextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 280);
            this.Controls.Add(this.CostotextBox);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ProductoIDnumericUpDown);
            this.Controls.Add(this.ValorInventariolabel);
            this.Controls.Add(this.Costolabel);
            this.Controls.Add(this.Existencialabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.ProductoIDlabel);
            this.Name = "Form1";
            this.Text = "Registro de productos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox ValorInventariotextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.TextBox CostotextBox;
    }
}

