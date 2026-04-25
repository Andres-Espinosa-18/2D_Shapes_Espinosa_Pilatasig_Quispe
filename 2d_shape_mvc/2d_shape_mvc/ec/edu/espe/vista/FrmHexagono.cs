using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.utils;
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
    public partial class FrmHexagono : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        public FrmHexagono()
        {
            InitializeComponent();
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado;
            lado = double.Parse(txtLongitud.Text.Trim());

            var resultado=controlador.calcularHexagono(lado);
            dibujador = resultado.hexagono.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString();
            txtArea.Text=resultado.area.ToString();

            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height);
        }
    }
}
