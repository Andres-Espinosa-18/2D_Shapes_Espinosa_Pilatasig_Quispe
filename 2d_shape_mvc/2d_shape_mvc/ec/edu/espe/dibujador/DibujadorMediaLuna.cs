using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal class DibujadorMediaLuna : IDibujador
    {
        private MediaLuna mediaLuna;
        public DibujadorMediaLuna(MediaLuna mediaLuna) { this.mediaLuna = mediaLuna; }

        public void dibujarFigura(Graphics g, int w, int h)
        {
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Escala libre: multiplicamos el radio por 4 para que sea visible
            int diametro = (int)(mediaLuna.getRadio() * 4);

            // Centramos la figura matemáticamente
            int x = (w - diametro) / 2;
            int y = (h - diametro) / 2;

            // 1. Creamos el círculo base
            GraphicsPath lunaBase = new GraphicsPath();
            lunaBase.AddEllipse(x, y, diametro, diametro);

            // 2. Creamos el círculo que va a "cortar" al primero. 
            // Lo desplazamos hacia arriba (restando a 'y') para que los cuernos apunten arriba.
            GraphicsPath recorte = new GraphicsPath();
            recorte.AddEllipse(x, y - (diametro / 3), diametro, diametro);

            // 3. Aplicamos la exclusión (resta de figuras)
            Region regionFinal = new Region(lunaBase);
            regionFinal.Exclude(recorte);

            // 4. Dibujamos la región resultante con el color naranja de la imagen
            using (SolidBrush brush = new SolidBrush(Color.DarkOrange))
            {
                g.FillRegion(brush, regionFinal);
            }
        }
    }
}