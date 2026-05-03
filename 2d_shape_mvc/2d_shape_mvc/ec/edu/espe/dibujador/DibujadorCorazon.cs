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
            float t = (float)corazon.Lado;

            // El rombo tiene diagonales: horizontal = 2t, vertical = 2t
            // Los semicírculos tienen radio = t/2, y se colocan sobre los lados superiores del rombo

           
            float cx = w / 2f;
            float cy = h / 2f + (t * 0.25f); // bajar un poco para centrar visualmente

            // --- Vértices del rombo ---
            // El rombo: arriba-izquierda, arriba-derecha, abajo, izquierda
            PointF top = new PointF(cx, cy - t);       // vértice superior (centro)
            PointF right = new PointF(cx + t, cy);               // vértice derecho
            PointF bottom = new PointF(cx, cy + t);       // vértice inferior
            PointF left = new PointF(cx - t, cy);               // vértice izquierdo

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                // --- Dibujar el rombo ---
                g.FillPolygon(brush, new PointF[] { top, right, bottom, left });

                // --- Semicírculo izquierdo ---
                // Centro entre vértice izquierdo y vértice superior del rombo
                float scxL = (left.X + top.X) / 2f;
                float scyL = (left.Y + top.Y) / 2f;
                float radio = (t) / 2f; // radio = mitad del lado del rombo (aprox)
                
                g.FillPie(brush,
                    scxL - radio, scyL - radio,
                    t, t,
                    135f,   // ángulo de inicio: apunta hacia adentro del rombo
                    180f);       // semicírculo = 180°

                // --- Semicírculo derecho ---
                float scxR = (right.X + top.X) / 2f;
                float scyR = (right.Y + top.Y) / 2f;

                g.FillPie(brush,
                    scxR - radio, scyR - radio,
                    radio * 2, radio * 2,
                    225f,        // ángulo de inicio: apunta hacia adentro del rombo  
                    180f);       // semicírculo = 180°
            }
        }
    }
}