using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.utils;
using _2D_shape_mvc;
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
    public partial class FrmCometa : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        public FrmCometa()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
        }

        private void limpiarFormulario()
        {
            txtDiagonal1.Clear();
            txtDiagonal2.Clear();
            txtInterseccion.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtDiagonal1.Text) || v.isEmpty(txtDiagonal2.Text) || v.isEmpty(txtInterseccion.Text))
            {
                lblMensaje.Text = "La entrada no debe estar vacia. Ingrese un número";
                return;
            }

            if (!v.isNumbers(txtDiagonal1.Text) || !v.isNumbers(txtDiagonal2.Text) || !v.isNumbers(txtInterseccion.Text))
            {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            double diag1 = double.Parse(txtDiagonal1.Text);
            double diag2 = double.Parse(txtDiagonal2.Text);
            double inter = double.Parse(txtInterseccion.Text);

            if (!v.isPositive(diag1) || !v.isPositive(diag2) || !v.isPositive(inter))
            {
                lblMensaje.Text = "La entrada debe ser mayor que 0. Ingrese un número válido";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularCometa(diag2, diag1, inter);
            dibujador = resultado.cometa.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString("F2");
            txtArea.Text = resultado.area.ToString("F2");
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
