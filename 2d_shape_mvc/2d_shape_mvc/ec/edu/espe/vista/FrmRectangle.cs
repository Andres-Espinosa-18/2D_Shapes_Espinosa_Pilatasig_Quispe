using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.modelo;
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
    public partial class FrmRectangle : Form
    {

        private Validacion v;
        private FiguraControlador controlador;
        private IDibujador dibujador;

        public FrmRectangle(){
            InitializeComponent();
            this.v = new Validacion();
            this.controlador = new FiguraControlador();
        }

        private void limpiarFormulario(){
            txtLargo.Clear();
            txtAncho.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            lblMensaje.Text = "";

            dibujador = null;
            panelDibujo.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e){
            if (v.isEmpty(txtLargo.Text) || v.isEmpty(txtAncho.Text)){
                lblMensaje.Text = "La entrada no puede estar vacia. Ingrese un número.";
                return;
            }

            if(!v.isNumbers(txtLargo.Text)|| !v.isNumbers(txtAncho.Text)){
                lblMensaje.Text = "La entrada debe ser númerica. Ingrese un número válido.";
                return;
            }

            double largo, ancho;
            largo = double.Parse(txtLargo.Text.Trim());
            ancho = double.Parse(txtAncho.Text.Trim());

            if(!v.isPositive(largo) || !v.isPositive(ancho)){
                lblMensaje.Text = "La entrada debe ser positiva. Ingrese un número válido.";
                return;
            }

            lblMensaje.Text = "";

            var resultado = controlador.calcularRectangulo(largo, ancho);
            dibujador = resultado.rectangulo.crearDibujador();

            txtPerimetro.Text = resultado.perimetro.ToString("F2");
            txtArea.Text = resultado.area.ToString("F2");
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e){
            e.Graphics.Clear(Color.White);
            if (dibujador == null) return;

            dibujador.dibujarFigura(e.Graphics, panelDibujo.Width, panelDibujo.Height);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {

        }
    }
}
