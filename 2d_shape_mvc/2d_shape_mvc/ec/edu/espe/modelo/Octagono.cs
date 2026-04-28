using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.dibujador;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Octagono : IFigura
    {
        public double lado { get; set; }

        public double Perimetro => 8 * lado;

        public double Area => 2 * (1 + Math.Sqrt(2)) * lado * lado;

        public Octagono(double lado)
        {
            if (lado <= 0) { throw new ArgumentException("El lado debe ser mayor a 0"); }
            this.lado = lado;
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
            return new DibujadorOctagono(this);
        }
    }
}
