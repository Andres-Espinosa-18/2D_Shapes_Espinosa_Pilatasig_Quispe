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

        public void dibujarFigura(Graphics g, int w, int h)
        {
            if (estrella == null) return;

            int margen = 20;

            // 🔷 Obtener vértices del modelo (centrados en 0,0)
            var puntos = estrella.generarVertices();

            // 🔷 Calcular tamaño máximo actual (bounding box)
            float maxX = puntos.Max(p => p.X);
            float minX = puntos.Min(p => p.X);
            float maxY = puntos.Max(p => p.Y);
            float minY = puntos.Min(p => p.Y);

            float ancho = maxX - minX;
            float alto = maxY - minY;

            // 🔷 Escala proporcional
            float escala = Math.Min(
                (w - 2 * margen) / ancho,
                (h - 2 * margen) / alto
            );

            // 🔷 Centro del panel
            float cx = w / 2f;
            float cy = h / 2f;

            // 🔷 Transformar puntos (escala + traslación)
            List<PointF> puntosTransformados = new List<PointF>();

            foreach (var p in puntos)
            {
                float x = cx + (p.X * escala);
                float y = cy + (p.Y * escala);

                puntosTransformados.Add(new PointF(x, y));
            }

            // 🔷 Mejor calidad de dibujo
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen lapiz = new Pen(Color.Gold, 3))
            {
                g.DrawPolygon(lapiz, puntosTransformados.ToArray());
            }
        }
    }
}