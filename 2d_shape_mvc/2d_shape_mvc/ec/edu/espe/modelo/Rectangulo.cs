using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Rectangulo : IFigura
    {

        private double largo;
        private double ancho;

        public Rectangulo(double largo, double ancho){
            if (largo <= 0 || ancho <= 0)
                throw new ArgumentException("Los datos ingresados deben ser mayores a 0");
            this.largo = largo;
            this.ancho = ancho;
        }

        public double getLargo(){
            return this.largo;
        }

        public double getAncho(){
            return this.ancho;
        }

        public void setAlto(double largo){
            this.largo = largo;
        }

        public void setAncho(double ancho){
            this.ancho = ancho;
        }

        public double calcularArea()
        {
            return this.largo * this.ancho;
        }

        public double calcularPerimetro(){
            return 2 * (this.largo + this.ancho);
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorRectangulo(this);
        }
    }
}
