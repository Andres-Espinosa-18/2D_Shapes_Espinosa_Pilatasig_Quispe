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
    public partial class FrmPentagono : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        public FrmPentagono()
        {
            InitializeComponent();
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
        }

        private void LimpiarFormulario()
        {
            txtLongitud.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtLongitud.Text))
            {
                lblMensaje.Text = "La entrada no debe estar vacia. Ingrese un número.";
                return;
            }

            if (!v.isNumbers(txtLongitud.Text))
            {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            double lado=double.Parse(txtLongitud.Text.Trim());

            if (!v.isPositive(lado))
            {
                lblMensaje.Text = "La entrada debe ser mayor a 0. Ingrese un número válido.";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularPentagono(lado);
            dibujador = resultado.pentagono.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString("F2");
            txtArea.Text=resultado.area.ToString("F2");
            panelDibujo.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height);
        }
    }
}
