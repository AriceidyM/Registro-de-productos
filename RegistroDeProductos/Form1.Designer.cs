﻿namespace RegistroDeProductos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rProductoToolStripMenuItem,
            this.rConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rProductoToolStripMenuItem
            // 
            this.rProductoToolStripMenuItem.Name = "rProductoToolStripMenuItem";
            this.rProductoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rProductoToolStripMenuItem.Text = "rProductos";
            this.rProductoToolStripMenuItem.Click += new System.EventHandler(this.RProductoToolStripMenuItem_Click);
            // 
            // rConsultasToolStripMenuItem
            // 
            this.rConsultasToolStripMenuItem.Name = "rConsultasToolStripMenuItem";
            this.rConsultasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.rConsultasToolStripMenuItem.Text = "rConsultas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroDeProductos.Properties.Resources.productos;
            this.ClientSize = new System.Drawing.Size(505, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Registro de productos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rConsultasToolStripMenuItem;
    }
}

