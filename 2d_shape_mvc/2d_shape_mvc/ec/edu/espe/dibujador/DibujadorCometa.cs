using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorCometa : IDibujador
    {
        private Cometa cometa;

        public DibujadorCometa(Cometa cometa)
        {
            this.cometa = cometa;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            double d1 = cometa.diagonal1;
            double d2 = cometa.diagonal2;
            double it = cometa.interseccion;

            double escala = Math.Min((w - 40) / d2, (h - 40) / d1);

            float dw = (float)(d2);
            float dh = (float)(d1);
            float di = (float)(d1 * it);

            float cx = w / 2f;
            float cy = h / 2f;
            float yTop = cy - (dh / 2f);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            using (SolidBrush brush = new SolidBrush(Color.Tomato))
            {
                g.FillPolygon(brush, new PointF[] {
                    new PointF(cx, yTop),            
                    new PointF(cx + dw/2f, yTop + di), 
                    new PointF(cx, yTop + dh),
                    new PointF(cx - dw/2f, yTop + di)
                });
            }
        }
    }
}
