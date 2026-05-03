using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.utils;
using _2D_shape_mvc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2d_shape_mvc.ec.edu.espe.vista
{
    public partial class FrmCruz : Form
    {
        private FiguraControlador controlador;
        private Validacion validador;

        public FrmCruz()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);

            controlador = new FiguraControlador();
            validador = new Validacion();

            // Enlazamos los eventos si no lo están desde el diseñador
            btnCalcular.Click += btnCalcular_Click;
            btnRestaurar.Click += btnRestaurar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void FrmCruz_Load(object sender, EventArgs e)
        {
            txtArea.ReadOnly = true;
            txtPerimetro.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strLado = txtLado.Text;

            // Validaciones
            if (validador.isEmpty(strLado))
            {
                MessageBox.Show("El campo 'Lado' no puede estar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validador.isNumbers(strLado))
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double lado = Convert.ToDouble(strLado);

            if (!validador.isPositive(lado))
            {
                MessageBox.Show("El lado debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Llamada al controlador
                var resultado = controlador.calcularCruz(lado);

                txtPerimetro.Text = Math.Round(resultado.perimetro, 2).ToString();
                txtArea.Text = Math.Round(resultado.area, 2).ToString();

                // Dibujado (Asegúrate de que tu panel se llame panel1 como en tu captura)
                Graphics g = panel1.CreateGraphics();
                IDibujador dibujador = resultado.cruz.crearDibujador();

                dibujador.dibujarFigura(g, panel1.Width, panel1.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();

            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);

            txtLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }
    }
}