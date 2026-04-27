using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Paralelogramo:IFigura
    {
        private double basep;
        private double lado;
        private double angulo;

        public Paralelogramo(double basep, double lado, double angulo)
        {
            if(basep<=0||lado<=0||angulo<=0|| angulo >= 180) { throw new ArgumentException("Los datos ingresados no representan un paralelogramo"); }
            this.basep = basep;
            this.lado = lado;
            this.angulo = angulo * Math.PI / 180;
        }

        public double getBasep() {return basep;}

        public double getLado() { return lado; }

        public double getAngulo() {return angulo;}

        public double calcularArea()
        {
            return basep * lado * Math.Sin(angulo);
        }

        public double calcularPerimetro()
        {
            return 2 * (basep + lado);
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorParalelogramo(this);
        }
    }
}
