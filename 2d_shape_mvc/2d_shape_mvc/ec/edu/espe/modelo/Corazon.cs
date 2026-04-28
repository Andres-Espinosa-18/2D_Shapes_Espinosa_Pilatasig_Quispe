using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.dibujador;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Corazon : IFigura
    {
        public double tamanio { get; set; }

        // Perímetro aproximado de la curva del corazón (integración numérica)
        public double Perimetro
        {
            get
            {
                int pasos = 1000;
                double total = 0;
                for (int i = 0; i < pasos; i++)
                {
                    double t1 = 2 * Math.PI * i / pasos;
                    double t2 = 2 * Math.PI * (i + 1) / pasos;

                    double x1 = tamanio * 16 * Math.Pow(Math.Sin(t1), 3);
                    double y1 = tamanio * (13 * Math.Cos(t1) - 5 * Math.Cos(2 * t1) - 2 * Math.Cos(3 * t1) - Math.Cos(4 * t1));
                    double x2 = tamanio * 16 * Math.Pow(Math.Sin(t2), 3);
                    double y2 = tamanio * (13 * Math.Cos(t2) - 5 * Math.Cos(2 * t2) - 2 * Math.Cos(3 * t2) - Math.Cos(4 * t2));

                    total += Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                }
                return total;
            }
        }

        // Área aproximada usando la fórmula de Shoelace (polígono muestreado)
        public double Area
        {
            get
            {
                int pasos = 1000;
                double area = 0;
                for (int i = 0; i < pasos; i++)
                {
                    double t1 = 2 * Math.PI * i / pasos;
                    double t2 = 2 * Math.PI * (i + 1) / pasos;

                    double x1 = tamanio * 16 * Math.Pow(Math.Sin(t1), 3);
                    double y1 = tamanio * (13 * Math.Cos(t1) - 5 * Math.Cos(2 * t1) - 2 * Math.Cos(3 * t1) - Math.Cos(4 * t1));
                    double x2 = tamanio * 16 * Math.Pow(Math.Sin(t2), 3);
                    double y2 = tamanio * (13 * Math.Cos(t2) - 5 * Math.Cos(2 * t2) - 2 * Math.Cos(3 * t2) - Math.Cos(4 * t2));

                    area += (x1 * y2 - x2 * y1);
                }
                return Math.Abs(area) / 2.0;
            }
        }

        public Corazon(double tamanio)
        {
            if (tamanio <= 0) { throw new ArgumentException("El tamaño debe ser mayor a 0"); }
            this.tamanio = tamanio;
        }

        public double calcularPerimetro()
        {
            return this.Perimetro;
        }

        public double calcularArea()
        {
            return this.Area;
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorCorazon(this);
        }
    }
}
