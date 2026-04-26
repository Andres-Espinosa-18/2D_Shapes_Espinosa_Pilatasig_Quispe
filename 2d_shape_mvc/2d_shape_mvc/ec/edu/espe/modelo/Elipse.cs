using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Elipse : IFigura
    {
        private double ancho;
        private double alto;

        public Elipse(double ancho, double alto)
        {
            if(ancho<=0 || alto <= 0) { throw new ArgumentException("los datos ingresados deben ser mayores a 0"); }
            this.ancho = ancho;
            this.alto = alto;
        }

        public double getAlto()
        {
            return this.alto;
        }

        public double getAncho()
        {
            return this.ancho;
        }

        public void setAlto(double alto)
        {
            this.alto = alto;
        }

        public void setAncho(double ancho)
        {
            this.ancho=ancho;
        }

        public double calcularArea()
        {
            return Math.PI * this.ancho * this.alto * 0.25;
        }

        //Para caucluar el perímetro se utiliza la Aproximación de Ramanujan
        //Ya que es más facil de programar, además de utilizar menos recursos que realizar 
        //Una integral elíptica.
        public double calcularPerimetro()
        {
            double a = alto / 2;
            double b = ancho / 2;

            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorElipse(this);
        }
    }
}
