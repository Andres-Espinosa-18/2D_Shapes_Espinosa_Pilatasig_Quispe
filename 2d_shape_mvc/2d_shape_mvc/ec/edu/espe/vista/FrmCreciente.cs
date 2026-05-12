using System;
using System.Drawing;
using System.Windows.Forms;
using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.modelo;
using _2d_shape_mvc.ec.edu.espe.utils;
using _2D_shape_mvc;

namespace _2d_shape_mvc.ec.edu.espe.vista
{
    public partial class FrmCreciente : Form
    {
        private FiguraControlador controlador;
        private Validacion validador;
        private Deformacion deformador;

        public FrmCreciente()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);

            controlador = new FiguraControlador();
            validador = new Validacion();

            // Enlazamos los eventos a los botones
            this.Load += FrmCreciente_Load;
            btnCalcular.Click += btnCalcular_Click;
            btnRestaurar.Click += btnRestaurar_Click;
            btnSalir.Click += btnSalir_Click;

            this.deformador = new Deformacion();
        }

        private void FrmCreciente_Load(object sender, EventArgs e)
        {
            txtArea.ReadOnly = true;
            txtPerimetro.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strRadio = txtRadio.Text;

            // Validaciones
            if (validador.isEmpty(strRadio))
            {
                MessageBox.Show("El campo 'Radio' no puede estar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validador.isNumbers(strRadio))
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double radio = Convert.ToDouble(strRadio);

            if (!validador.isPositive(radio))
            {
                MessageBox.Show("El radio debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Llamada al controlador (asumiendo que tu método se llama calcularMediaLuna)
                var resultado = controlador.calcularMediaLuna(radio);

                txtPerimetro.Text = Math.Round(resultado.perimetro, 2).ToString();
                txtArea.Text = Math.Round(resultado.area, 2).ToString();

                // Dibujado en el panel
                Graphics g = panelDibujo.CreateGraphics();
                IDibujador dibujador = resultado.medialuna.crearDibujador();

                dibujador.dibujarFigura(g, panelDibujo.Width, panelDibujo.Height, deformador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();

            Graphics g = panelDibujo.CreateGraphics();
            g.Clear(Color.White);

            txtRadio.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}