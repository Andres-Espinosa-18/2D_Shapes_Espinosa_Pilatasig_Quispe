using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_shape_mvc.ec.edu.espe.vista
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void miRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle frmRectangulo = new FrmRectangle();
            frmRectangulo.MdiParent = this;
            frmRectangulo.Show();
        }

        private void miTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangulo = new FrmTriangle();
            frmTriangulo.MdiParent = this;
            frmTriangulo.Show();
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono frmHexagono = new FrmHexagono();
            frmHexagono.MdiParent = this;
            frmHexagono.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadraro frmCuadrado = new FrmCuadraro();
            frmCuadrado.MdiParent = this;
            frmCuadrado.Show();
        }
    }
}
