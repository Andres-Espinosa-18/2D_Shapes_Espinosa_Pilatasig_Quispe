using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorHexagono : IDibujador
    {
        private Hexagono hexagono;

        public DibujadorHexagono(Hexagono hexagono)
        {
            this.hexagono= hexagono;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            int cx = w / 2;
            int cy = h / 2;

            int size = Math.Min(w, h);
            float radio = size * 0.4f;

            List<PointF> vertices = new List<PointF>();

            for (int i = 0; i < 6; i++)
            {
                double angulo = (i * 60) * Math.PI / 180;

                float x = (float)(radio * Math.Cos(angulo));
                float y = (float)(radio * Math.Sin(angulo));

                vertices.Add(new PointF(cx + x, cy + y));
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.Coral, 3))
            {
                g.DrawPolygon(p, vertices.ToArray());
            }
        }
    }
}
