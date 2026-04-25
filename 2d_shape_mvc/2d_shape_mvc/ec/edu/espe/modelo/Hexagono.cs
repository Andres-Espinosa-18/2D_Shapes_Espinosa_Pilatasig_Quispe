using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Hexagono : IFigura
    {

        private double lado;

        public Hexagono(double lado)
        {
            if (lado <= 0)
            {
                throw new ArgumentException("El lado del hexagono no debe ser menor o igual a 0");
            }

            this.lado = lado;

        }

        public double getLado()
        {
            return this.lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double calcularArea()
        {
            return 3 * Math.Sqrt(3) / 2 * lado * lado;
        }

        public double calcularPerimetro()
        {
            return 6 * lado;
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorHexagono(this);
        }
    }
}
