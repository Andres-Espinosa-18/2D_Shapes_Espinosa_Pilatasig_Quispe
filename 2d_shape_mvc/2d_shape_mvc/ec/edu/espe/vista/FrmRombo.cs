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
    public partial class FrmRombo : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        private Deformacion deformador;
        public FrmRombo()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
            this.deformador = new Deformacion();
        }

        private void limpiarFormulario()
        {
            txtDiagonal1.Clear();
            txtDiagonal2.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtDiagonal1.Text) || v.isEmpty(txtDiagonal2.Text))
            {
                lblMensaje.Text = "La entrada no debe estar vacia. Ingrese un número";
                return;
            }

            if (!v.isNumbers(txtDiagonal1.Text) || !v.isNumbers(txtDiagonal2.Text))
            {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            double diag1 = double.Parse(txtDiagonal1.Text);
            double diag2 = double.Parse(txtDiagonal2.Text);
            double inter = 0.5;

            if (!v.isPositive(diag1) || !v.isPositive(diag2))
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

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height, deformador);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {

        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }
    }
}
