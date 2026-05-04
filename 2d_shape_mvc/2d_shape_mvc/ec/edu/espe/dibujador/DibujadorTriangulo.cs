using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorTriangulo: IDibujador
    {

        private Triangulo triangulo;

        public DibujadorTriangulo(Triangulo triangulo)
        {
            this.triangulo = triangulo;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            int margen = 40;

            double a = triangulo.getLado1();
            double b = triangulo.getLado2();
            double c = triangulo.getLado3();

            double baseLength = c;

            // Ley de cosenos
            double x = (a * a + c * c - b * b) / (2 * c);
            double y = Math.Sqrt(a * a - x * x);

            double escala = 1.0;

            // Verificar si se sale (ancho = base, alto = altura del triángulo)
            if ((baseLength + 2 * margen) > w || (y + 2 * margen) > h)
            {
                escala = Math.Min(
                    (w - 2 * margen) / baseLength,
                    (h - 2 * margen) / y
                );
            }

            // Coordenadas base (sin escalar aún)
            double x1 = margen;
            double y1 = h - margen;

            double x2 = x1 + baseLength * escala;
            double y2 = y1;

            double x3 = x1 + x * escala;
            double y3 = y1 - y * escala;

            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.Aquamarine, 3))
            using (Brush brush = new SolidBrush(lapiz.Color))
            {
                Point[] puntos = new Point[]
                {
            new Point((int)x1, (int)y1),
            new Point((int)x2, (int)y2),
            new Point((int)x3, (int)y3)
                };

                g.FillPolygon(brush, puntos);
                g.DrawPolygon(lapiz, puntos); // borde
            }
        }
    }
}
