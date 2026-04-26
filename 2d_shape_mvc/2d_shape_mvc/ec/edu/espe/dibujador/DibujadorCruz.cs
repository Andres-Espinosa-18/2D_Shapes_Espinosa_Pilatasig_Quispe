using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Drawing;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorCruz : IDibujador
    {
        private Cruz cruz;
        public DibujadorCruz(Cruz cruz) { this.cruz = cruz; }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Escala libre: multiplicamos el lado ingresado por 4 para tener un tamaño visible
            int unit = (int)(cruz.getLado() * 4);

            // Centro del panel
            int cx = w / 2;
            int cy = h / 2;

            // Calculamos los 12 vértices de la cruz basándonos en el centro y la unidad
            Point[] vertices = new Point[]
            {
                new Point(cx - unit/2, cy - (int)(unit*1.5)), // 1. Arriba izq
                new Point(cx + unit/2, cy - (int)(unit*1.5)), // 2. Arriba der
                new Point(cx + unit/2, cy - unit/2),          // 3. Interior der-arriba
                new Point(cx + (int)(unit*1.5), cy - unit/2), // 4. Derecha arriba
                new Point(cx + (int)(unit*1.5), cy + unit/2), // 5. Derecha abajo
                new Point(cx + unit/2, cy + unit/2),          // 6. Interior der-abajo
                new Point(cx + unit/2, cy + (int)(unit*1.5)), // 7. Abajo der
                new Point(cx - unit/2, cy + (int)(unit*1.5)), // 8. Abajo izq
                new Point(cx - unit/2, cy + unit/2),          // 9. Interior izq-abajo
                new Point(cx - (int)(unit*1.5), cy + unit/2), // 10. Izquierda abajo
                new Point(cx - (int)(unit*1.5), cy - unit/2), // 11. Izquierda arriba
                new Point(cx - unit/2, cy - unit/2)           // 12. Interior izq-arriba
            };

            // Color morado/fucsia como en la imagen original
            using (SolidBrush brush = new SolidBrush(Color.MediumVioletRed))
            {
                g.FillPolygon(brush, vertices);
            }
        }
    }
}