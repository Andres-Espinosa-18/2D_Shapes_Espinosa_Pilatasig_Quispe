using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorPentagono : IDibujador
    {
        private Pentagono pentagono;

        public DibujadorPentagono(Pentagono pentagono)
        {
            this.pentagono = pentagono;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            double lado = pentagono.getLado();
            double radio = lado / (2 * Math.Cos(Math.PI / 5));

            List<PointF> puntos = new List<PointF>();

            for (int i = 0; i < 5; i++)
            {
                double angulo = i * 2 * Math.PI / 5;

                float x = (float)(radio * Math.Cos(angulo));
                float y = (float)(radio * Math.Sin(angulo));

                puntos.Add(new PointF(x, y));
            }

            // 🔷 Bounding box
            float maxX = puntos.Max(p => p.X);
            float minX = puntos.Min(p => p.X);
            float maxY = puntos.Max(p => p.Y);
            float minY = puntos.Min(p => p.Y);

            float ancho = maxX - minX;
            float alto = maxY - minY;

            int margen = 40; // 🔥 aquí defines el límite

            float escala = 1f;

            // 🔴 Solo escalar si se va a salir
            if (ancho > (w - 2 * margen) || alto > (h - 2 * margen))
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / alto
                );
            }

            float cx = w / 2f;
            float cy = h / 2f;

            List<PointF> puntosTransformados = new List<PointF>();

            foreach (var p in puntos)
            {
                float x = cx + p.X * escala;
                float y = cy + p.Y * escala;

                puntosTransformados.Add(new PointF(x, y));
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.Chocolate, 3))
            {
                g.DrawPolygon(p, puntosTransformados.ToArray());
            }
        }
    }
}
