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
        public double Lado { get; set; }

        // El lado del rombo
        public double ladoRombo => Math.Sqrt(2) * Lado;

        // Radio de cada semicírculo = mitad del lado del rombo
        public double radioSemi => ladoRombo / 2.0;

        // Perímetro: mitad inferior del rombo (2 lados) + 2 semicírculos (= 1 círculo completo)
        public double Perimetro => 2 * ladoRombo + 2 * Math.PI * radioSemi;

        // Área: rombo + 2 semicírculos (= 1 círculo completo)
        public double Area => 2 * Lado * Lado + Math.PI * radioSemi * radioSemi;

        public Corazon(double lado)
        {
            if (lado <= 0) { throw new ArgumentException("El lado debe ser mayor a 0"); }
            this.Lado = lado;
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
