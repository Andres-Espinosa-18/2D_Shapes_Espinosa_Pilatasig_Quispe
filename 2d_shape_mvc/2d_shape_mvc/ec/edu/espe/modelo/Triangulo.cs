using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Triangulo : IFigura
    {

        private double l1, l2, l3;

        public Triangulo(double lado1, double lado2, double lado3) { 
            if(lado1<=0 || lado2 <= 0 || lado3 <= 0) { throw new ArgumentException("Los lados deben ser mayores a 0");}
            if(lado1 + lado2 <= lado3 || 
               lado1 + lado3 <= lado2 || 
               lado2 + lado3 <= lado1) { throw new ArgumentException("Los lados no forman un triangulo valido");}
            this.l1 = lado1;
            this.l2 = lado2;
            this.l3 = lado3;
        }

        public double getLado1(){
            return this.l1;
        }

        public double getLado2(){
            return this.l2;
        }

        public double getLado3(){
            return this.l3;
        }

        public void setLado1(double lado){
            this.l1 = lado;
        }

        public void setLado2(double lado){
            this.l2 = lado;
        }

        public void setLado3(double lado){
            this.l3 = lado;
        }

        public double calcularPerimetro(){
            return this.l1 + this.l2 + this.l3;
        }
        public double calcularArea(){

            double s = calcularPerimetro() / 2;
            return Math.Sqrt(s * (s - this.l1) * (s - this.l2) * (s - this.l3));
        }

        public IDibujador crearDibujador()
        {
            return new DibujadorTriangulo(this);
        }
    }
}