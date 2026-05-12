using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorCometa : IDibujador
    {
        private Cometa cometa;

        public DibujadorCometa(Cometa cometa)
        {
            this.cometa = cometa;
        }

        public void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion)
        {
            double d1 = cometa.diagonal1;
            double d2 = cometa.diagonal2;
            double it = cometa.interseccion;

            double escala = deformacion.Escala;

            float dw = (float)(d2 * escala);
            float dh = (float)(d1 * escala);
            float di = (float)(d1 * it * escala);

            float cx = w / 2f + (float)deformacion.OffsetX;
            float cy = h / 2f + (float)deformacion.OffsetY;
            float yTop = 0 - (dh / 2f);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.Clear(Color.White);

            PointF[] puntos = new PointF[]
            {
                new PointF(0, yTop),
                new PointF(dw/2f, yTop + di),
                new PointF(0, yTop + dh),
                new PointF(0 - dw/2f, yTop + di)
            };

            PointF[] puntosFinales = deformacion.RotarPuntos(puntos, cx, cy);

            using (SolidBrush brush = new SolidBrush(Color.Tomato))
            {
                g.FillPolygon(brush, puntosFinales);

            }
        }
    }
}
