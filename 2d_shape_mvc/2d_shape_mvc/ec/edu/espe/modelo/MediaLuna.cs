using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class MediaLuna : IFigura
    {
        private double radio;

        public MediaLuna(double radio)
        {
            if (radio <= 0) throw new ArgumentException("El radio debe ser mayor a 0");
            this.radio = radio;
        }

        public double getRadio() => this.radio;

        // Área y perímetro aproximados por simplicidad geométrica
        public double calcularArea() => Math.PI * Math.Pow(radio, 2) * 0.4;
        public double calcularPerimetro() => 2 * Math.PI * radio;

        public IDibujador crearDibujador() => new DibujadorMediaLuna(this);
    }
}