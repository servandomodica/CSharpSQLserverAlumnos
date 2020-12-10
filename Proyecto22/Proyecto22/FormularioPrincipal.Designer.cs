using System;

namespace Proyecto22
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptosPorCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeCarrerasToolStripMenuItem,
            this.mantenimientoDeAlumnosToolStripMenuItem,
            this.inscripcionesDeAlumnosToolStripMenuItem,
            this.inscriptosPorCarreraToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mantenimientoDeCarrerasToolStripMenuItem
            // 
            this.mantenimientoDeCarrerasToolStripMenuItem.Name = "mantenimientoDeCarrerasToolStripMenuItem";
            this.mantenimientoDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.mantenimientoDeCarrerasToolStripMenuItem.Text = "Mantenimiento de carreras";
            this.mantenimientoDeCarrerasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeCarrerasToolStripMenuItem_Click);
            // 
            // mantenimientoDeAlumnosToolStripMenuItem
            // 
            this.mantenimientoDeAlumnosToolStripMenuItem.Name = "mantenimientoDeAlumnosToolStripMenuItem";
            this.mantenimientoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.mantenimientoDeAlumnosToolStripMenuItem.Text = "Mantenimiento de alumnos";
            this.mantenimientoDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeAlumnosToolStripMenuItem_Click);
            // 
            // inscripcionesDeAlumnosToolStripMenuItem
            // 
            this.inscripcionesDeAlumnosToolStripMenuItem.Name = "inscripcionesDeAlumnosToolStripMenuItem";
            this.inscripcionesDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.inscripcionesDeAlumnosToolStripMenuItem.Text = "Inscripciones de alumnos";
            this.inscripcionesDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesDeAlumnosToolStripMenuItem_Click);
            // 
            // inscriptosPorCarreraToolStripMenuItem
            // 
            this.inscriptosPorCarreraToolStripMenuItem.Name = "inscriptosPorCarreraToolStripMenuItem";
            this.inscriptosPorCarreraToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.inscriptosPorCarreraToolStripMenuItem.Text = "Inscriptos por carrera";
            this.inscriptosPorCarreraToolStripMenuItem.Click += new System.EventHandler(this.inscriptosPorCarreraToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptosPorCarreraToolStripMenuItem;
    }
}

