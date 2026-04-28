using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorOctagono : IDibujador
    {
        private Octagono octagono;

        public DibujadorOctagono(Octagono octagono)
        {
            this.octagono = octagono;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            double lado = octagono.lado;

            // El octágono regular cabe en un cuadrado de lado: (1 + √2) * lado
            double tamTotal = (1 + Math.Sqrt(2)) * lado;

            double escala = Math.Min((w - 40) / tamTotal, (h - 40) / tamTotal);

            float l = (float)(lado * escala);
            float cut = (float)(l / Math.Sqrt(2)); // longitud del corte en las esquinas

            float cx = w / 2f;
            float cy = h / 2f;
            float half = (float)(tamTotal * escala / 2f);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Los 8 vértices del octágono regular, empezando desde arriba-izquierda en sentido horario
            PointF[] puntos = new PointF[]
            {
                new PointF(cx - l/2f,        cy - half),       // arriba izquierda
                new PointF(cx + l/2f,        cy - half),       // arriba derecha
                new PointF(cx + half,        cy - l/2f),       // derecha arriba
                new PointF(cx + half,        cy + l/2f),       // derecha abajo
                new PointF(cx + l/2f,        cy + half),       // abajo derecha
                new PointF(cx - l/2f,        cy + half),       // abajo izquierda
                new PointF(cx - half,        cy + l/2f),       // izquierda abajo
                new PointF(cx - half,        cy - l/2f),       // izquierda arriba
            };

            using (SolidBrush brush = new SolidBrush(Color.Cyan))
            {
                g.FillPolygon(brush, puntos);
            }
        }
    }
}
