namespace RegistroDeProductos.UI.Consultas
{
    partial class rConsultas
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
            this.ValorTotalDeInventariolabel = new System.Windows.Forms.Label();
            this.ValorDeInventariotextBox = new System.Windows.Forms.TextBox();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValorTotalDeInventariolabel
            // 
            this.ValorTotalDeInventariolabel.AutoSize = true;
            this.ValorTotalDeInventariolabel.Location = new System.Drawing.Point(44, 47);
            this.ValorTotalDeInventariolabel.Name = "ValorTotalDeInventariolabel";
            this.ValorTotalDeInventariolabel.Size = new System.Drawing.Size(116, 13);
            this.ValorTotalDeInventariolabel.TabIndex = 1;
            this.ValorTotalDeInventariolabel.Text = "ValorTotalDeInventario";
            // 
            // ValorDeInventariotextBox
            // 
            this.ValorDeInventariotextBox.Location = new System.Drawing.Point(47, 98);
            this.ValorDeInventariotextBox.Name = "ValorDeInventariotextBox";
            this.ValorDeInventariotextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorDeInventariotextBox.TabIndex = 2;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Image = global::RegistroDeProductos.Properties.Resources.Actions_edit_redo_icon;
            this.Actualizarbutton.Location = new System.Drawing.Point(213, 47);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(75, 55);
            this.Actualizarbutton.TabIndex = 0;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // rConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 166);
            this.Controls.Add(this.ValorDeInventariotextBox);
            this.Controls.Add(this.ValorTotalDeInventariolabel);
            this.Controls.Add(this.Actualizarbutton);
            this.Name = "rConsultas";
            this.Text = "rConsultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Label ValorTotalDeInventariolabel;
        private System.Windows.Forms.TextBox ValorDeInventariotextBox;
    }
}