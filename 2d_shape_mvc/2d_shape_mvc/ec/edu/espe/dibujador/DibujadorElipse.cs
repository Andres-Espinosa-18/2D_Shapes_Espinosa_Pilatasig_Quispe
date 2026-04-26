using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorElipse : IDibujador
    {
        private Elipse elipse;

        public DibujadorElipse(Elipse elipse)
        {
            this.elipse = elipse;
        }
        public void dibujarFigura(Graphics g, int w, int h)
        {
            int margen = 20;

            double ancho = elipse.getAncho();
            double alto = elipse.getAlto();

            // Escala proporcional
            double escala = Math.Min(
                (w - 2 * margen) / ancho,
                (h - 2 * margen) / alto
            );

            float drawWidth = (float)(ancho * escala);
            float drawHeight = (float)(alto * escala);

            float cx = w / 2;
            float cy = h / 2;

            float x = cx - drawWidth / 2;
            float y = cy - drawHeight / 2;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.BurlyWood, 3))
            {
                g.DrawEllipse(p, x, y, drawWidth, drawHeight);
            }
        }
    }
}
