using System.Drawing;
using System.Windows.Forms;

namespace _2D_shape_mvc // Asegúrate de que este sea el namespace de tu proyecto
{
    public static class TemaVisual
    {
        public static void Aplicar(Form formulario)
        {
            // 1. Aplicar estilo general al formulario
            formulario.BackColor = Color.FromArgb(240, 244, 248);
            formulario.Font = new Font("Segoe UI", 10f);

            // 2. Buscar y estilizar todos los controles por dentro
            AplicarAControles(formulario.Controls);
        }

        private static void AplicarAControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.ForeColor = Color.White;

                    // --- NUEVO: Estandarizar el tamaño de todos los botones ---
                    btn.Size = new Size(110, 40);

                    // --- NUEVO: Forzar color, posición y orden exacto ---
                    // Nota: Los valores de 'Point(X, Y)' son coordenadas. 
                    if (btn.Text == "Salir")
                    {
                        btn.BackColor = Color.FromArgb(220, 53, 69);
                        btn.Location = new Point(80, 550); // Primer botón a la izquierda
                    }
                    else if (btn.Text == "Calcular")
                    {
                        btn.BackColor = Color.FromArgb(13, 110, 253);
                        btn.Location = new Point(200, 550); // En el medio
                    }
                    else if (btn.Text == "Resetear")
                    {
                        btn.BackColor = Color.FromArgb(108, 117, 125);
                        btn.Location = new Point(320, 550); // Tercer botón
                    }
                }
                else if (c is Panel pnl && (pnl.Name == "panelDibujo" || pnl.Name == "panel1"))
                {
                    pnl.BackColor = Color.White;
                    pnl.BorderStyle = BorderStyle.FixedSingle;

                    // --- NUEVO: Estandarizar el cuadro de dibujo en todos los forms ---
                    pnl.Size = new Size(800, 650); // Ancho y Alto exactos
                    pnl.Location = new Point(500, 80); // Posición X, Y exacta a la derecha
                }
            }
        }
    }
}