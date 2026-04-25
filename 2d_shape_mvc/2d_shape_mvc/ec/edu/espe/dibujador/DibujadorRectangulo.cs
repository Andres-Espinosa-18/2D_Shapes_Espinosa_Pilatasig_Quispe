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
            Pen pen = new Pen(Color.Orange, 3);
            double escala = Math.Min((w - 20) / rectangulo.getAncho(), (h - 20) / rectangulo.getLargo());

            int dw = (int)(rectangulo.getAncho() * escala);
            int dh = (int)(rectangulo.getLargo() * escala);

            int x = (w - dw) / 2;
            int y = (h - dh) / 2;

            g.Clear(Color.White);
            g.FillRectangle(Brushes.Yellow, x, y, dw, dh);
            g.DrawRectangle(pen, x, y, dw, dh);
            
        }
    }
}
