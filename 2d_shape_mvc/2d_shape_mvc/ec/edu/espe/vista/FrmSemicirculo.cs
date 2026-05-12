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
    public partial class FrmSemicirculo : Form
    {
        private FiguraControlador controlador;
        private Validacion validador;
        private Deformacion deformador;

        public FrmSemicirculo()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);

            // Inicializamos nuestras clases de lógica y validación
            controlador = new FiguraControlador();
            validador = new Validacion();
            this.deformador = new Deformacion();
        }

        private void FrmSemicirculo_Load(object sender, EventArgs e)
        {
            // Opcional: Configurar los TextBox de salida como de solo lectura
            txtArea.ReadOnly = true;
            txtPerimetro.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strRadio = txtRadio.Text;

            // 1. Validaciones
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
                // 2. Ejecutar la lógica mediante el Controlador
                var resultado = controlador.calcularSemicirculo(radio);

                // 3. Mostrar los resultados en la interfaz (redondeados a 2 decimales para estética)
                txtPerimetro.Text = Math.Round(resultado.perimetro, 2).ToString();
                txtArea.Text = Math.Round(resultado.area, 2).ToString();

                // 4. Dibujar la figura en el panel
                Graphics g = panelDibujo.CreateGraphics();
                IDibujador dibujador = resultado.semicirculo.crearDibujador();

                // Pasamos las dimensiones del panel para que el dibujador la centre
                dibujador.dibujarFigura(g, panelDibujo.Width, panelDibujo.Height, deformador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txtRadio.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();

            // Limpiar el panel de dibujo (Color blanco por defecto o el que tenga tu panel)
            Graphics g = panelDibujo.CreateGraphics();
            g.Clear(Color.White);

            // Devolver el foco al primer campo
            txtRadio.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra este formulario para regresar al Menú Principal (FrmHome)
            this.Close();
        }
    }
}