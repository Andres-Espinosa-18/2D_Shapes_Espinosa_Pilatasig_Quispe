using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorTrapecio : IDibujador
    {
        private Trapecio trapecio;

        public DibujadorTrapecio(Trapecio trapecio)
        {
            this.trapecio = trapecio;
        }

        public void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion)
        {
            double B = trapecio.getBaseMayor();
            double b = trapecio.getBaseMenor();
            double hTrap = trapecio.getAltura();

            // 🔷 desplazamiento para centrar la base menor
            double d = (B - b) / 2.0;

            // 🔷 vértices en (0,0)
            List<PointF> puntos = new List<PointF>();

            PointF A = new PointF(0, 0);
            PointF Bp = new PointF((float)B, 0);
            PointF C = new PointF((float)(B - d), (float)hTrap);
            PointF D = new PointF((float)d, (float)hTrap);

            puntos.Add(A);
            puntos.Add(Bp);
            puntos.Add(C);
            puntos.Add(D);

            // 🔷 bounding box
            float maxX = puntos.Max(p => p.X);
            float minX = puntos.Min(p => p.X);
            float maxY = puntos.Max(p => p.Y);
            float minY = puntos.Min(p => p.Y);

            float ancho = maxX - minX;
            float alto = maxY - minY;

            int margen = 40;
            float escala = 1f;

            // 🔴 Escalar solo si se va a salir
            if (ancho > (w - 2 * margen) || alto > (h - 2 * margen))
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / alto
                );
            }

            // 🔷 centro panel
            float cx = w / 2f;
            float cy = h / 2f;

            // 🔷 centro real figura
            float centroX = (minX + maxX) / 2;
            float centroY = (minY + maxY) / 2;

            // 🔷 transformar puntos
            List<PointF> puntosTransformados = new List<PointF>();

            foreach (var p in puntos)
            {
                float x = cx + (p.X - centroX) * escala;
                float y = cy + (p.Y - centroY) * escala;

                puntosTransformados.Add(new PointF(x, y));
            }

            // 🔷 dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.MediumVioletRed, 3))
            using (Brush brush = new SolidBrush(lapiz.Color))
            {
                g.FillPolygon(brush, puntosTransformados.ToArray());
                g.DrawPolygon(lapiz, puntosTransformados.ToArray());
            }
        }
    }
}