using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Pentagono : IFigura
    {
        private double lado;

        public Pentagono(double lado)
        {
            if (lado <= 0) { throw new ArgumentException("La entrada debe ser mayor a 0");}
            this.lado = lado;
        }

        public double getLado()
        {
            return this.lado;
        }
        public double calcularArea()
        {
            return 5 * 0.5 * Math.Tan(0.3 * Math.PI) * lado * lado;
        }

        public double calcularPerimetro()
        {
            return 5 * lado;
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorPentagono(this);
        }
    }
}
