using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorHexagono : IDibujador
    {
        private Hexagono hexagono;

        public DibujadorHexagono(Hexagono hexagono)
        {
            this.hexagono = hexagono;
        }

        public void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion)
        {
            // Limpiar el fondo
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = w / 2;
            int cy = h / 2;

            // Escala libre: multiplicamos el lado ingresado por 4 para que sea visible
            // En un hexágono regular, el radio (distancia del centro al vértice) es igual a su lado
            int numPoly = 6;
            // Convertimos 180 a radianes para la función Sin
            double anguloCentralRad = (180.0 / numPoly) * Math.PI / 180;

            // Radio real necesario para que el lado mida lo que dice 'hexagono.getLado()'
            // Aplicamos el factor de escala * 4 que ya tenías
            float ladoEscalado = (float)(hexagono.getLado() * 4);
            float radio = (float)(ladoEscalado / (2 * Math.Sin(anguloCentralRad)));
            List<PointF> vertices = new List<PointF>();
            double polygonAng = 360 / numPoly;
            double rotacion = (90 - (polygonAng / 2)) * Math.PI / 180;
            // Calcular los 6 puntos
            for (int i = 0; i < numPoly; i++)
            {
                double angulo = (i * polygonAng) * Math.PI / 180 + rotacion;

                float x = (float)(radio * Math.Cos(angulo));
                float y = (float)(radio * Math.Sin(angulo));

                vertices.Add(new PointF(cx + x, cy + y));
            }

            // Usamos SolidBrush y FillPolygon para que la figura aparezca pintada (rellena)
            using (SolidBrush brush = new SolidBrush(Color.DeepSkyBlue))
            {
                g.FillPolygon(brush, vertices.ToArray());
            }
        }
    }
}