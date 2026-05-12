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
    public partial class FrmCirculo : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        private Deformacion deformador;
        public FrmCirculo()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
            this.deformador = new Deformacion();
        }

        private void limpiarFormulario()
        {
            txtRadio.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtRadio.Text)){
                lblMensaje.Text = "La entrada no debe estar vacia. Ingrese un número";
                return;
            }

            if (!v.isNumbers(txtRadio.Text)) {
                lblMensaje.Text = "La entrada debe ser numérica. Ingrese un número.";
                return;
            }

            double radio=double.Parse(txtRadio.Text);

            if (!v.isPositive(radio))
            {
                lblMensaje.Text = "La entrada debe ser mayor que 0. Ingrese un número válido";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularElipse(radio * 2, radio * 2);
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

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height, deformador);
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
