using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Trebol : IFigura
    {
        private double radioHoja;

        public Trebol(double radioHoja)
        {
            if (radioHoja <= 0) throw new ArgumentException("El radio debe ser mayor a 0");
            this.radioHoja = radioHoja;
        }

        public double getRadioHoja() => this.radioHoja;

        public double calcularArea() => 3 * Math.PI * Math.Pow(radioHoja, 2);
        public double calcularPerimetro() => 3 * 2 * Math.PI * radioHoja;

        public IDibujador crearDibujador() => new DibujadorTrebol(this);
    }
}