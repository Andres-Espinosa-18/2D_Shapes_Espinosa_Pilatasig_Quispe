using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorCorazon : IDibujador
    {
        private Corazon corazon;

        public DibujadorCorazon(Corazon corazon)
        {
            this.corazon = corazon;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            int pasos = 500;

            // El corazón paramétrico cabe en X: [-16t, 16t], Y: [-17t, 13t]
            double anchoMax = 32 * corazon.tamanio;
            double altoMax = 30 * corazon.tamanio;

            double escala = Math.Min((w - 40) / anchoMax, (h - 40) / altoMax);

            float cx = w / 2f;
            float cy = h / 2f + (float)(1.5 * corazon.tamanio * escala) - 25; // centrar verticalmente

            PointF[] puntos = new PointF[pasos];

            for (int i = 0; i < pasos; i++)
            {
                double t = 2 * Math.PI * i / pasos;

                double x = 16 * Math.Pow(Math.Sin(t), 3);
                double y = 13 * Math.Cos(t) - 5 * Math.Cos(2 * t) - 2 * Math.Cos(3 * t) - Math.Cos(4 * t);

                puntos[i] = new PointF(
                    cx + (float)(x * corazon.tamanio * escala),
                    cy - (float)(y * corazon.tamanio * escala)  // Y invertido porque GDI+ crece hacia abajo
                );
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                g.FillPolygon(brush, puntos);
            }
        }
    }
}