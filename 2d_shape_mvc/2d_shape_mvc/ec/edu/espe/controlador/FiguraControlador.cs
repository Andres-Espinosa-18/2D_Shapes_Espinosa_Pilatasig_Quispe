using _2d_shape_mvc.ec.edu.espe.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.controlador
{
    internal class FiguraControlador
    {
        private IFigura figura;

        public (IFigura rectangulo, double perimetro, double area) calcularRectangulo(double largo, double ancho)
        {
            figura = new Rectangulo(largo, ancho);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura triangulo, double perimetro, double area) calcularTriangulo(double l1, double l2, double l3)
        {
            figura = new Triangulo(l1, l2, l3);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura hexagono, double perimetro, double area) calcularHexagono(double lado)
        {
            figura = new Hexagono(lado);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura semicirculo, double perimetro, double area) calcularSemicirculo(double radio)
        {
            figura = new Semicirculo(radio);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura cruz, double perimetro, double area) calcularCruz(double lado)
        {
            figura = new Cruz(lado);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura medialuna, double perimetro, double area) calcularMediaLuna(double radio)
        {
            figura = new MediaLuna(radio);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura trebol, double perimetro, double area) calcularTrebol(double radioHoja)
        {
            figura = new Trebol(radioHoja);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public (IFigura elipse, double perimetro, double area) calcularElipse(double ancho, double alto)
        {
            figura = new Elipse(ancho, alto);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }

        public(IFigura Estrella, double perimetro, double area) calcularEstrella(int numPuntas, double radioExterior, double radioInterior)
        {
            figura = new Estrella(numPuntas, radioExterior, radioInterior);
            return (figura, figura.calcularPerimetro(), figura.calcularArea());
        }
    }
}