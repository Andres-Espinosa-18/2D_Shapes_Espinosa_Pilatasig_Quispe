using _2d_shape_mvc.ec.edu.espe.controlador;
using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.utils;
using _2D_shape_mvc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2d_shape_mvc.ec.edu.espe.vista
{
    public partial class FrmTrebol : Form
    {
        private FiguraControlador controlador;
        private Validacion validador;

        public FrmTrebol()
        {
            InitializeComponent();
            TemaVisual.Aplicar(this);

            controlador = new FiguraControlador();
            validador = new Validacion();

            // Si deseas, puedes enlazar los eventos aquí o desde el diseñador visual
            this.Load += FrmTrebol_Load;
            btnCalcular.Click += btnCalcular_Click;
            btnResetear.Click += btnResetear_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void FrmTrebol_Load(object sender, EventArgs e)
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
                // Llamada al controlador
                var resultado = controlador.calcularTrebol(radio);

                txtPerimetro.Text = Math.Round(resultado.perimetro, 2).ToString();
                txtArea.Text = Math.Round(resultado.area, 2).ToString();

                // Dibujado
                Graphics g = panelDibujo.CreateGraphics();
                IDibujador dibujador = resultado.trebol.crearDibujador();

                dibujador.dibujarFigura(g, panelDibujo.Width, panelDibujo.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
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

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}