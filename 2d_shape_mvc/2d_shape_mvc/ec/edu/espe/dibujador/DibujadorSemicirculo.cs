using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Drawing;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorSemicirculo : IDibujador
    {
        private Semicirculo semi;
        public DibujadorSemicirculo(Semicirculo semi) { this.semi = semi; }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Eliminamos el límite. 
            // Multiplicamos el radio por 3 para que tenga una escala visible agradable.
            // Si el radio es 50, el tamaño será de 150 píxeles.
            int size = (int)(semi.getRadio() * 3);

            // Centramos la figura en el panel dinámicamente
            int x = (w - size) / 2;
            int y = (h - size) / 2;

            using (SolidBrush brush = new SolidBrush(Color.Tomato))
            {
                // Dibuja el semicírculo
                g.FillPie(brush, x, y, size, size, 180, 180);
            }
        }
    }
}