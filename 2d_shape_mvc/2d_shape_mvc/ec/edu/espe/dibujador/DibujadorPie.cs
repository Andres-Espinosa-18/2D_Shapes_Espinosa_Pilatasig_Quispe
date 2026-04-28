using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorPie : IDibujador
    {
        private Pie pie;

        public DibujadorPie(Pie pie)
        {
            this.pie = pie;
        }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            double radio = pie.radio;
            double inicio = pie.anguloInicio;
            double fin = pie.anguloFin;

            double escala = Math.Min((w - 40) / (radio * 2), (h - 40) / (radio * 2));

            float r = (float)(radio * escala);
            float cx = w / 2f;
            float cy = h / 2f;

            float sweepAngle = (float)(fin - inicio);
            // Si el ángulo de barrido es negativo (ej. de 350 a 10), 
            // le sumamos 360 para que recorra el sentido horario.
            if (sweepAngle < 0) sweepAngle += 360;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            using (SolidBrush brush = new SolidBrush(Color.Tomato))
            {
                g.FillPie(brush, cx - r, cy - r, r * 2, r * 2, (float)inicio, sweepAngle);
            }
        }
    }
}
