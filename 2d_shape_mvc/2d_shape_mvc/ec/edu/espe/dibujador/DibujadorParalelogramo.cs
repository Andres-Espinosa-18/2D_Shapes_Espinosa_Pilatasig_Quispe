using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorParalelogramo : IDibujador
    {
        private Paralelogramo paralelogramo;

        public DibujadorParalelogramo(Paralelogramo paralelogramo)
        {
            this.paralelogramo = paralelogramo;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            double b = paralelogramo.getBasep();
            double l = paralelogramo.getLado();
            double theta = paralelogramo.getAngulo(); // YA en radianes

            // 🔷 Generar vértices en (0,0)
            List<PointF> puntos = new List<PointF>();

            PointF A = new PointF(0, 0);
            PointF B = new PointF((float)b, 0);

            PointF C = new PointF(
                (float)(b + l * Math.Cos(theta)),
                (float)(l * Math.Sin(theta))
            );

            PointF D = new PointF(
                (float)(l * Math.Cos(theta)),
                (float)(l * Math.Sin(theta))
            );

            puntos.Add(A);
            puntos.Add(B);
            puntos.Add(C);
            puntos.Add(D);

            // 🔷 Bounding box
            float maxX = puntos.Max(p => p.X);
            float minX = puntos.Min(p => p.X);
            float maxY = puntos.Max(p => p.Y);
            float minY = puntos.Min(p => p.Y);

            float ancho = maxX - minX;
            float alto = maxY - minY;

            int margen = 40;

            float escala = 1f;

            // 🔴 Escalar solo si se va a salir del panel
            if (ancho > (w - 2 * margen) || alto > (h - 2 * margen))
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / alto
                );
            }

            // 🔷 Centro del panel
            float cx = w / 2f;
            float cy = h / 2f;

            // 🔷 Centro REAL de la figura
            float centroX = (minX + maxX) / 2;
            float centroY = (minY + maxY) / 2;

            // 🔷 Transformar puntos (centrado correcto)
            List<PointF> puntosTransformados = new List<PointF>();

            foreach (var p in puntos)
            {
                float x = cx + (p.X - centroX) * escala;
                float y = cy + (p.Y - centroY) * escala;

                puntosTransformados.Add(new PointF(x, y));
            }

            // 🔷 Dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.DarkCyan, 3))
            {
                g.DrawPolygon(lapiz, puntosTransformados.ToArray());
            }
        }
    }
}