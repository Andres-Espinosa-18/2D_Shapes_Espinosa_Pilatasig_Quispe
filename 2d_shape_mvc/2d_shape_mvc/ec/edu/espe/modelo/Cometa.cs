using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.dibujador;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Cometa : IFigura
    {
        public double diagonal1 { get; set; }
        public double diagonal2 { get; set; }
        public double interseccion { get; set; }

        public double ladoA => Math.Sqrt((diagonal1 * interseccion) * (diagonal1 * interseccion) + (diagonal2 * 0.5) * (diagonal2 * 0.5));
        public double ladoB => Math.Sqrt((diagonal1 * (1 - interseccion)) * (diagonal1 * (1 - interseccion)) + (diagonal2 * 0.5) * (diagonal2 * 0.5));
        public double Perimetro => ladoA * 2 + ladoB * 2;
        public double Area => (diagonal1 * interseccion * diagonal2 * 0.5) + (diagonal1 * (1 - interseccion) * diagonal2 * 0.5);

        public Cometa(double diagonal1, double diagonal2, double interseccion)
        {
            if (interseccion < 0 || interseccion > 1) { throw new ArgumentException("La interseccion debe tener valor de 0 a 1"); }
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            this.interseccion = interseccion        ;
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
            return new DibujadorTriangulo(this);
        }
    }
}
}
