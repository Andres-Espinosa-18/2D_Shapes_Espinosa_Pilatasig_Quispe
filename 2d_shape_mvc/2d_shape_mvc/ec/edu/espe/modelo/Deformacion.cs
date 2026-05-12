using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Deformacion
    {
        public double Escala { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
        public double angulo { get; set; }

        public Deformacion()
        {
            this.Escala = 1;
            this.OffsetX = 0;
            this.OffsetY = 0;
            this.angulo = 0;
        }

        public PointF rotacionCoord( PointF punto, float cx, float cy)
        {
            PointF rotado = new PointF((punto.X * (float) Math.Cos(angulo) - punto.Y * (float) Math.Sin(angulo)) + cx
                                        ,(punto.X * (float)Math.Sin(angulo) + punto.Y * (float)Math.Cos(angulo)) + cy);
            return rotado;
        }

        public PointF[] RotarPuntos(PointF[] puntos, float cx, float cy)
        {
            PointF[] puntosRotados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosRotados[i] = rotacionCoord(puntos[i], cx, cy);
            }

            return puntosRotados;
        }
    }
}
