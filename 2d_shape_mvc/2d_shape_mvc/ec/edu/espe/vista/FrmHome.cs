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

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frmEllipse = new FrmElipse();
            frmEllipse.MdiParent = this;
            frmEllipse.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirculo = new FrmCirculo();
            frmCirculo.MdiParent = this;
            frmCirculo.Show();
        }


        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono frmPentagono = new FrmPentagono();
            frmPentagono.MdiParent = this;
            frmPentagono.Show();
        }

        private void paralelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParalelogramo frmParalelogramo = new FrmParalelogramo();
            frmParalelogramo.MdiParent = this;
            frmParalelogramo.Show();
        }


        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = new FrmTrapecio();
            frmTrapecio.MdiParent = this;
            frmTrapecio.Show();
        }


        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagono frmOctagono = new FrmOctagono();
            frmOctagono.MdiParent = this;
            frmOctagono.Show();
        }


        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = new FrmRombo();
            frmRombo.MdiParent = this;
            frmRombo.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangulo = new FrmTriangle();
            frmTriangulo.MdiParent = this;
            frmTriangulo.Show();
        }

        private void trianguloEscalenoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEscaleneTriangle frmEscaleneTriangle = new FrmEscaleneTriangle();
            frmEscaleneTriangle.MdiParent = this;
            frmEscaleneTriangle.Show();
        }

        private void trebolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrebol frmTrebol = new FrmTrebol();
            frmTrebol.MdiParent = this;
            frmTrebol.Show();
        }

        private void crecienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreciente frmCreciente = new FrmCreciente();
            frmCreciente.MdiParent = this;
            frmCreciente.Show();
        }

        private void cruzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCruz frmCruz = new FrmCruz();
            frmCruz.MdiParent = this;
            frmCruz.Show();
        }

        private void estrellaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEstrella frmEstrella = new FrmEstrella();
            frmEstrella.MdiParent = this;
            frmEstrella.Show();
        }

        private void cometaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCometa frmCometa = new FrmCometa();
            frmCometa.MdiParent = this;
            frmCometa.Show();
        }

        private void pieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPie frmPie = new FrmPie();
            frmPie.MdiParent = this;
            frmPie.Show();
        }

        private void corazonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCorazon frmCorazon = new FrmCorazon();
            frmCorazon.MdiParent = this;
            frmCorazon.Show();
        }

        private void semicirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemicirculo frmSemicirculo = new FrmSemicirculo();
            frmSemicirculo.MdiParent = this;
            frmSemicirculo.Show();
        }
    }
}