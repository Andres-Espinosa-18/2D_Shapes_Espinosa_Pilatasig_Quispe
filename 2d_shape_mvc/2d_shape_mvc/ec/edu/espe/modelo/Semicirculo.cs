using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Semicirculo : IFigura
    {
        private double radio;

        public Semicirculo(double radio)
        {
            if (radio <= 0) throw new ArgumentException("El radio debe ser mayor a 0");
            this.radio = radio;
        }

        public double getRadio() => this.radio;

        public double calcularArea() => (Math.PI * Math.Pow(radio, 2)) / 2;

        public double calcularPerimetro() => (Math.PI * radio) + (2 * radio);

        public IDibujador crearDibujador() => new DibujadorSemicirculo(this);
    }
}