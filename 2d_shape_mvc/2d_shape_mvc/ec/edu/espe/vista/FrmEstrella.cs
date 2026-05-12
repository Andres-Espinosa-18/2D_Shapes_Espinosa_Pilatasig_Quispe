using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.modelo;
using _2d_shape_mvc.ec.edu.espe.utils;
using _2D_shape_mvc;

namespace _2d_shape_mvc.ec.edu.espe.vista
{
    public partial class FrmEstrella : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        private Deformacion deformador;
        public FrmEstrella()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
            deformador = new Deformacion();
        }

        private void limpiarFormulario()
        {
            txtNumPuntas.Clear();
            txtRadioExterior.Clear();
            txtRadioInterior.Clear();
            lblMensaje.Text = "";
            txtPerimetro.Clear();
            txtArea.Clear();

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtNumPuntas.Text) || v.isEmpty(txtRadioExterior.Text) || v.isEmpty(txtRadioInterior.Text)) {
                lblMensaje.Text = "La entrada debe estar vacia. Ingrese un número.";
                return;
            }

            if (!v.isNumbers(txtNumPuntas.Text) || !v.isNumbers(txtRadioExterior.Text) || !v.isNumbers(txtRadioInterior.Text)) {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            int numPuntas = (int)(double.Parse(txtNumPuntas.Text.Trim()));
            double radioInterior, radioExterior;

            radioInterior = double.Parse(txtRadioInterior.Text.Trim());
            radioExterior = double.Parse(txtRadioExterior.Text.Trim());

            if (!v.isPositive(numPuntas) || !v.isPositive(radioInterior) || !v.isPositive(radioExterior))
            {
                lblMensaje.Text = "Las entradas deben ser mayores a 0. Ingrese un número válido";
                return;
            }

            if (!v.validarEstrellaFrm(numPuntas, radioExterior, radioInterior))
            {
                lblMensaje.Text = "Las entradas no representan una estrella de 5 puntas o mayores. Ingrese las entradas nuevamente";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularEstrella(numPuntas, radioExterior, radioInterior);
            dibujador = resultado.Estrella.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString("F2");
            txtArea.Text = resultado.area.ToString("F2");
            panelDibujo.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Width, deformador);

        }

        private void txtRadioExterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRadioInterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRadioInterior_Click(object sender, EventArgs e)
        {

        }

        private void txtNumPuntas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPuntas_Click(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
