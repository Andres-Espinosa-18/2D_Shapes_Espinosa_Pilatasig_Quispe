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
    public partial class FrmTriangle : Form
    {
        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;
        private Deformacion deformador;
        public FrmTriangle()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
            this.deformador = new Deformacion();
        }

        private void limpiarFormulario()
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            lblMensaje.Text = "";

            txtPerimetro.Clear();
            txtArea.Clear();
            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(v.isEmpty(txtLado1.Text)||v.isEmpty(txtLado2.Text)|| v.isEmpty(txtLado3.Text))
            {
                lblMensaje.Text = "La entrada no puede estar vacia. Ingrese un número.";
                return;
            }

            if (!v.isNumbers(txtLado1.Text) || !v.isNumbers(txtLado2.Text) || !v.isNumbers(txtLado3.Text))
            {
                lblMensaje.Size = new Size(200, 50);
                lblMensaje.Text = "La entrada debe ser númerica. Ingrese un número válido.";
                return;
            }

            double l1, l2, l3;
            l1 = double.Parse(txtLado1.Text.Trim());
            l2 = double.Parse(txtLado2.Text.Trim());
            l3 = double.Parse(txtLado3.Text.Trim());

            if(!v.isPositive(l1)|| !v.isPositive(l2)|| !v.isPositive(l3))
            {
                lblMensaje.Size = new Size(200, 50);
                lblMensaje.Text = "La entrada debe ser positiva. Ingrese un número válido.";
                return;
            }

            if (!v.validarTriangulo(l1, l2, l3))
            {
                lblMensaje.Size = new Size(200, 50);
                lblMensaje.Text = "Los lados ingresados no forman un triángulo válido. Revise sus datos.";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularTriangulo(l1, l2, l3);
            dibujador = resultado.triangulo.crearDibujador();

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
    }
}
