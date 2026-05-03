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
    public partial class FrmElipse : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        public FrmElipse()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();

        }

        private void limpiarFormulario()
        {
            txtAlto.Clear();
            txtAncho.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            lblMensaje.Text = "";
            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (v.isEmpty(txtAlto.Text)|| v.isEmpty(txtAncho.Text))
            {
                lblMensaje.Text = "La entrada no puede estar vacia. Ingrese un número.";
                return;
            }

            if (!v.isNumbers(txtAlto.Text) || !v.isNumbers(txtAncho.Text))
            {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            double alto, ancho;
            alto = double.Parse(txtAlto.Text.Trim());
            ancho = double.Parse(txtAncho.Text.Trim());

            if (!v.isPositive(alto)|| !v.isPositive(ancho))
            {
                lblMensaje.Text = "Las Entradas deben ser mayores a 0. Ingrese un número válido";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularElipse(ancho, alto);
            dibujador = resultado.elipse.crearDibujador();

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

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height);
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {

        }
    }
}
