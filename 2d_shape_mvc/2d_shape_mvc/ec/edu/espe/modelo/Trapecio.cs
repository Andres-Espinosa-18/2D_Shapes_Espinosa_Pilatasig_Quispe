using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Trapecio : IFigura
    {

        private double baseMayor;
        private double baseMenor;
        private double altura;

        public Trapecio(double baseMayor, double baseMenor, double altura)
        {
            if(baseMayor<=0|| baseMenor<=0|| altura <= 0) { throw new ArgumentException("Los datos deben ser mayores a 0."); }
            if (baseMayor < baseMenor) { throw new ArgumentException("La base mayor debe ser mayor a la base menor"); }
            this.baseMayor = baseMayor; 
            this.baseMenor = baseMenor;
            this.altura = altura;
        }

        public double getBaseMayor() => baseMayor;
        public double getBaseMenor() => baseMenor;
        public double getAltura() => altura;

        public double calcularArea()
        {
            return (baseMayor + baseMenor) / 2 * altura;
        }

        public double calcularPerimetro()
        {
            double lado = Math.Sqrt(
                Math.Pow(altura, 2) +
                Math.Pow((baseMayor - baseMenor) / 2.0, 2)
            );

            return baseMayor + baseMenor + 2 * lado;
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorTrapecio(this);
        }
    }
}
