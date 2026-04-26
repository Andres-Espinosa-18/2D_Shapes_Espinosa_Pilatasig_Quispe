using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Cruz : IFigura
    {
        private double lado; // Lado de cada uno de los 5 cuadrados que forman la cruz

        public Cruz(double lado)
        {
            if (lado <= 0) throw new ArgumentException("El lado debe ser mayor a 0");
            this.lado = lado;
        }

        public double getLado() => this.lado;

        public double calcularArea() => 5 * Math.Pow(lado, 2);

        public double calcularPerimetro() => 12 * lado;

        public IDibujador crearDibujador() => new DibujadorCruz(this);
    }
}