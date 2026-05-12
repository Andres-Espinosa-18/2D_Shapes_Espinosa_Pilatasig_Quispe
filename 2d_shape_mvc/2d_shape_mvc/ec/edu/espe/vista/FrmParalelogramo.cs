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
    public partial class FrmParalelogramo : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        private Deformacion deformador;
        public FrmParalelogramo()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
            this.deformador = new Deformacion();
        }

        private void limpiarFormulario()
        {
            txtBase.Clear();
            txtLado.Clear();
            txtAngulo.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (v.isEmpty(txtBase.Text) || v.isEmpty(txtLado.Text) || v.isEmpty(txtAngulo.Text))
            {
                lblMensaje.Text = "Las entradas no deben estar vacias. Ingrese una entrada valida.";
                return;
            }

            if (!v.isNumbers(txtBase.Text) || !v.isNumbers(txtLado.Text) || !v.isNumbers(txtAngulo.Text))
            {
                lblMensaje.Text = "Las entradas deben ser numéricas. Ingrese una entrada válida.";
                return;
            }

            double basep, lado, angulo;
            basep = double.Parse(txtBase.Text.Trim());
            lado = double.Parse(txtLado.Text.Trim());
            angulo = double.Parse(txtAngulo.Text.Trim());

            if (!v.isPositive(basep) || !v.isPositive(lado))
            {
                lblMensaje.Text = "Las entradas deben ser positivas. Ingrese una entrada válida.";
                return;
            }

            if (!v.validarAngulo(angulo))
            {
                lblMensaje.Text = "El ángulo debe estar dentro del rango (0°, 180°). Ingrese un ángulo válido.";
                return;
            }

            var resultado = controlador.calcularParalelogramo(basep, lado, angulo);
            dibujador = resultado.paralelogramo.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString("F2");
            txtArea.Text = resultado.area.ToString("F2");
            panelDibujo.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height, deformador);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
