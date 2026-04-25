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
            int lado = (int)hexagono.getLado();

            int cx = (int)(w / 2);
            int cy = (int)(h / 2);

            Point point0= new Point(cx,cy);
            List<Point> vertices= new List<Point>();

            for (int i = 0; i < 6; i++) {
                double angulo = (i * 60) * Math.PI / 180;
                int x = (int)(lado * Math.Cos(angulo));
                int y = (int)(lado * Math.Sin(angulo));
                Point vertice = new Point(cx+x,cy+y);
                vertices.Add(vertice);
            }

            vertices.Add(vertices[0]);

            for(int i = 0; i < vertices.Count()-1; i++)
            {
                Point puntoActual = vertices[i];
                Point puntoSiguiente = vertices[i + 1];
                g.DrawPolygon(Pens.Coral, new Point[] {point0, puntoActual, puntoSiguiente});
            }

        }
    }
}
