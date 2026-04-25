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
            double a = triangulo.getLado1();
            double b = triangulo.getLado2();
            double c = triangulo.getLado3();

            double baseLength = c;

            double x = (a * a + c * c - b * b) / (2 * c);
            double y = Math.Sqrt(a * a - x * x);

            double escala = Math.Min((w - 40) / baseLength, (h - 40) / y);

            int x1 = 20;
            int y1 = h - 20;

            int x2 = (int)(x1 + baseLength * escala);
            int y2 = y1;

            int x3 = (int)(x1 + x * escala);
            int y3 = (int)(y1 - y * escala);

            g.Clear(Color.White);

            using (Pen lapiz = new Pen(Color.Aquamarine, 3))
            {
                g.DrawPolygon(lapiz, new Point[]
                {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
                });
            }
        }
    }
}
