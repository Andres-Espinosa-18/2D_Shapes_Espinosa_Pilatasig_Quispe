using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorRectangulo : IDibujador
    {
        private Rectangulo rectangulo;

        public DibujadorRectangulo(Rectangulo r)
        {
            this.rectangulo = r;
        }
        public void dibujarFigura(Graphics g, int w, int h)
        {

            int margen = 40;
            double largo = rectangulo.getLargo();
            double ancho = rectangulo.getAncho();

            double escala = 1;

            if (ancho > (w - 2 * margen) || largo > (h - 2 * margen))
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / largo
                );
            }

            int dw, dh;
            dw = (int)(ancho * escala);
            dh = (int)(largo * escala);

            int x = (w - dw) / 2;
            int y = (h - dh) / 2;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.DarkCyan, 3))
            using (Brush brocha = new SolidBrush(lapiz.Color))
            {
                g.FillRectangle(brocha, x, y, dw, dh);
                g.DrawRectangle(lapiz, x, y, dw, dh);
            }
        }
    }
}
