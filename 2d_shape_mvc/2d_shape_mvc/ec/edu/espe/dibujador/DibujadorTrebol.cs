using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Drawing;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorTrebol : IDibujador
    {
        private Trebol trebol;
        public DibujadorTrebol(Trebol trebol) { this.trebol = trebol; }

        public void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion)
        {
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Escala libre: multiplicamos el radio ingresado por 4 para obtener el diámetro de cada "hoja"
            int diametroHoja = (int)(trebol.getRadioHoja() * 4);

            // Centro del panel
            int cx = w / 2;
            int cy = h / 2;

            // Usamos color amarillo y semitransparente para que la intersección se vea mejor, 
            // o sólido si prefieres el estilo original de la imagen
            using (SolidBrush brush = new SolidBrush(Color.Yellow))
            {
                // Hoja superior
                g.FillEllipse(brush, cx - diametroHoja / 2, cy - diametroHoja + (diametroHoja / 4), diametroHoja, diametroHoja);

                // Hoja inferior izquierda
                g.FillEllipse(brush, cx - diametroHoja + (diametroHoja / 8), cy - (diametroHoja / 4), diametroHoja, diametroHoja);

                // Hoja inferior derecha
                g.FillEllipse(brush, cx - (diametroHoja / 8), cy - (diametroHoja / 4), diametroHoja, diametroHoja);
            }
        }
    }
}