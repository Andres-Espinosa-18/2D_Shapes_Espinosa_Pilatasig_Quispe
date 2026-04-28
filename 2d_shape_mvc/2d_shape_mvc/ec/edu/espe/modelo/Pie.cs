using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.dibujador;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Pie : IFigura
    {
        public double radio { get; set; }
        public double anguloInicio { get; set; }
        public double anguloFin { get; set; }

        // Ángulo del sector en radianes
        private double anguloSector => Math.Abs(anguloFin - anguloInicio) * Math.PI / 180.0;

        // Perímetro: 2 radios + arco
        public double Perimetro => 2 * radio + radio * anguloSector;

        // Área del sector circular
        public double Area => 0.5 * radio * radio * anguloSector;

        public Pie(double radio, double anguloInicio, double anguloFin)
        {
            if (radio <= 0) { throw new ArgumentException("El radio debe ser mayor a 0"); }
            if (anguloInicio < 0 || anguloInicio > 360) { throw new ArgumentException("El ángulo de inicio debe estar entre 0 y 360"); }
            if (anguloFin < 0 || anguloFin > 360) { throw new ArgumentException("El ángulo de fin debe estar entre 0 y 360"); }
            if (anguloInicio == anguloFin) { throw new ArgumentException("Los ángulos no pueden ser iguales"); }
            this.radio = radio;
            this.anguloInicio = anguloInicio;
            this.anguloFin = anguloFin;
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
            return new DibujadorPie(this);
        }
    }
}
