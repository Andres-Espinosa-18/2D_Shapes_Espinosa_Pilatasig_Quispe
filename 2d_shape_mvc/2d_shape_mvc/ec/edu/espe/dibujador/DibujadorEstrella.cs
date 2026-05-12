using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorEstrella : IDibujador
    {
        private Estrella estrella;

        public DibujadorEstrella(Estrella estrella)
        {
            this.estrella = estrella;
        }

        public void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion)
        {
            if (estrella == null) return;

            int margen = 40;

            var puntos = estrella.generarVertices();

            // 🔷 Bounding box
            float maxX = puntos.Max(p => p.X);
            float minX = puntos.Min(p => p.X);
            float maxY = puntos.Max(p => p.Y);
            float minY = puntos.Min(p => p.Y);

            float ancho = maxX - minX;
            float alto = maxY - minY;

            float escala = 1f;

            // 🔥 Solo escalar si se va a salir del panel
            if ((ancho + 2 * margen) > w || (alto + 2 * margen) > h)
            {
                escala = Math.Min(
                    (w - 2 * margen) / ancho,
                    (h - 2 * margen) / alto
                );
            }

            // 🔷 Centro del panel
            float cx = w / 2f;
            float cy = h / 2f;

            // 🔷 Transformar puntos (escala + centrado)
            List<PointF> puntosTransformados = new List<PointF>();

            foreach (var p in puntos)
            {
                float x = cx + (p.X * escala);
                float y = cy + (p.Y * escala);

                puntosTransformados.Add(new PointF(x, y));
            }

            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.Gold, 3))
            using (Brush brush = new SolidBrush(lapiz.Color)) // 🔥 mismo color
            {
                PointF[] pts = puntosTransformados.ToArray();

                g.FillPolygon(brush, pts); // 🔥 relleno
                g.DrawPolygon(lapiz, pts); // borde
            }
        }
    }
}