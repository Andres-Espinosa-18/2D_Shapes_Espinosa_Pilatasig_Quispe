using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.utils
{
    internal class Validacion
    {
        public bool isEmpty(string text){
            if (text == "")
                return true;
            return false;
        }

        public bool isNumbers(string text){
            double num;
            if (!double.TryParse(text, out num))
                return false;
            return true;
        }

        public bool isPositive(double number){
            return number > 0;
        }

        public bool validarTriangulo(double l1, double l2, double l3)
        {
            if (l1 + l2 <= l3 || l1 + l3 <= l2 || l2 + l3 <= l1)
                return false;
            return true;
        }

        public static void ValidarEstrella(int numPuntas, double radioExterior, double radioInterior)
        {
            if (numPuntas < 5)
                throw new ArgumentException("La estrella debe tener al menos 5 puntas.");

            if (radioExterior <= 0)
                throw new ArgumentException("El radio exterior debe ser mayor que cero.");

            if (radioInterior <= 0)
                throw new ArgumentException("El radio interior debe ser mayor que cero.");

            if (radioInterior >= radioExterior)
                throw new ArgumentException("El radio interior debe ser menor que el radio exterior.");
        }

        public bool validarEstrellaFrm(int numPuntas, double radioExterior, double radioInterior)
        {
            if (numPuntas < 5)
                return false;
            if (radioInterior >= radioExterior)
                return false;
            return true;
        }

        public bool validarAngulo(double angulo)
        {
            if (angulo <= 0 || angulo >= 180)
                return false;
            return true;
        }

        public bool validarTrianguloEscaleno(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                return false;
            return true;
        }

        public bool validarBaseMayor(double baseMayor, double baseMenor)
        {
            return baseMayor > baseMenor;
        }
    }
}
