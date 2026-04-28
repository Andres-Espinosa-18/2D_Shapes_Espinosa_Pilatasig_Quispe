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
    public partial class FrmTrapecio : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        public FrmTrapecio()
        {
            InitializeComponent();
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
        }

        private void limpiarFormulario()
        {
            txtBaseMayor.Clear();
            txtBaseMenor.Clear();
            txtAltura.Clear();
            lblMensaje.Text = "";
            txtPerimetro.Clear();
            txtArea.Clear();

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtBaseMayor.Text) || v.isEmpty(txtBaseMenor.Text) || v.isEmpty(txtAltura.Text))
            {
                lblMensaje.Text = "Las entradas no deben estar vacias. Ingrese un número.";
                return;
            }

            if (!v.isNumbers(txtBaseMayor.Text) || !v.isNumbers(txtBaseMenor.Text) || !v.isNumbers(txtAltura.Text)) {
                lblMensaje.Text = "Las entradas deben ser numéricas. Ingrese un número.";
                return;
            }

            double baseMayor, baseMenor, altura;
            baseMayor = double.Parse(txtBaseMayor.Text.Trim());
            baseMenor = double.Parse(txtBaseMenor.Text.Trim());
            altura= double.Parse(txtAltura.Text.Trim());

            if (!v.isPositive(baseMayor) || !v.isPositive(baseMenor) || !v.isPositive(altura)) {
                lblMensaje.Text = "Las entradas deben ser positivas. Ingrese un número válido.";
                return;
            }

            if(!v.validarBaseMayor(baseMayor, baseMenor))
            {
                lblMensaje.Text = "La Base mayor debe ser mayor a la Base menor. Revisa tus datos.";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularTrapecio(baseMayor, baseMenor, altura);
            dibujador = resultado.trapecio.crearDibujador();

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
    }
}
