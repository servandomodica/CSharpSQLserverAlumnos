using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto22
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }


        private void mantenimientoDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoDeCarreras m = new MantenimientoDeCarreras();
            m.ShowDialog();
        }

        private void mantenimientoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAlumnos m = new MantenimientoAlumnos();
            m.ShowDialog();
        }

        private void inscripcionesDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioInscripciones f = new FormularioInscripciones();
            f.ShowDialog();
        }

        private void inscriptosPorCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioInscriptosPorCarrera f = new FormularioInscriptosPorCarrera();
            f.ShowDialog();
        }
    }
}
