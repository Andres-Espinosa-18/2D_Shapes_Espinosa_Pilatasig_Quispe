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
            int margen = 40; // 🔥 tu condición

            double ancho = elipse.getAncho();
            double alto = elipse.getAlto();

            double escala = 1.0;

            // Verificar si se sale del panel (considerando margen)
            if (ancho > (w - 2 * margen) || alto > (h - 2 * margen))
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / alto
                );
            }

            float drawWidth = (float)(ancho * escala);
            float drawHeight = (float)(alto * escala);

            float cx = w / 2;
            float cy = h / 2;

            float x = cx - drawWidth / 2;
            float y = cy - drawHeight / 2;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.BurlyWood, 3))
            using (Brush b = new SolidBrush(p.Color))
            {
                g.FillEllipse(b, x, y, drawWidth, drawHeight);
                g.DrawEllipse(p, x, y, drawWidth, drawHeight); 
            }
        }
    }
}
