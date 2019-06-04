namespace RegistroDeProductos.UI.Registros
{
    partial class RegistroDeUbicaciones
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Gaurdarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(22, 28);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(22, 82);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(107, 28);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.IDnumericUpDown.TabIndex = 2;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(107, 82);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroDeProductos.Properties.Resources.new_file_icon;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(25, 148);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 34);
            this.Nuevobutton.TabIndex = 4;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Gaurdarbutton
            // 
            this.Gaurdarbutton.Image = global::RegistroDeProductos.Properties.Resources.Save_icon;
            this.Gaurdarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gaurdarbutton.Location = new System.Drawing.Point(120, 148);
            this.Gaurdarbutton.Name = "Gaurdarbutton";
            this.Gaurdarbutton.Size = new System.Drawing.Size(75, 34);
            this.Gaurdarbutton.TabIndex = 5;
            this.Gaurdarbutton.Text = "Guardar";
            this.Gaurdarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gaurdarbutton.UseVisualStyleBackColor = true;
            this.Gaurdarbutton.Click += new System.EventHandler(this.Gaurdarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroDeProductos.Properties.Resources.delete_icon;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(217, 148);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 34);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroDeProductos.Properties.Resources.Start_Menu_Search_icon;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(217, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 33);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegistroDeUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 214);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Gaurdarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.IDlabel);
            this.Name = "RegistroDeUbicaciones";
            this.Text = "RegistroDeUbicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Gaurdarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}