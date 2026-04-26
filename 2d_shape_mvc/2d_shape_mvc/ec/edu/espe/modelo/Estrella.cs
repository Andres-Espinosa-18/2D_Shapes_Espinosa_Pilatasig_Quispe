using _2d_shape_mvc.ec.edu.espe.dibujador;
using _2d_shape_mvc.ec.edu.espe.utils;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal class Estrella : IFigura
    {
        private int numPuntas;
        private double radioExterior;
        private double radioInterior;

        public Estrella(int numPuntas, double radioExterior, double radioInterior)
        {
            // 🔴 Validaciones críticas (modelo)
            Validacion.ValidarEstrella(numPuntas, radioExterior, radioInterior);

            this.numPuntas = numPuntas;
            this.radioExterior = radioExterior;
            this.radioInterior = radioInterior;
        }

        // 🔹 Getters
        public int getNumPuntas() => numPuntas;
        public double getRadioExterior() => radioExterior;
        public double getRadioInterior() => radioInterior;

        // 🔷 Generar vértices (centrado en 0,0)
        public List<PointF> generarVertices()
        {
            List<PointF> puntos = new List<PointF>();

            double anguloInicial = -Math.PI / 2;

            for (int i = 0; i < numPuntas * 2; i++)
            {
                double angulo = anguloInicial + i * Math.PI / numPuntas;

                double radio = (i % 2 == 0) ? radioExterior: radioInterior;

                float x = (float)(radio * Math.Cos(angulo));
                float y = (float)(radio * Math.Sin(angulo));

                puntos.Add(new PointF(x, y));
            }

            return puntos;
        }

        // 🔷 Área (shoelace)
        public double calcularArea()
        {
            var puntos = generarVertices();

            double suma = 0;
            int n = puntos.Count;

            for (int i = 0; i < n; i++)
            {
                PointF actual = puntos[i];
                PointF siguiente = puntos[(i + 1) % n];

                suma += (actual.X * siguiente.Y) - (siguiente.X * actual.Y);
            }

            return Math.Abs(suma) / 2.0;
        }

        // 🔷 Perímetro
        public double calcularPerimetro()
        {
            var puntos = generarVertices();

            double perimetro = 0;
            int n = puntos.Count;

            for (int i = 0; i < n; i++)
            {
                PointF actual = puntos[i];
                PointF siguiente = puntos[(i + 1) % n];

                double dx = siguiente.X - actual.X;
                double dy = siguiente.Y - actual.Y;

                perimetro += Math.Sqrt(dx * dx + dy * dy);
            }

            return perimetro;
        }

        // 🔷 Crear dibujador
        public IDibujador crearDibujador()
        {
            return new DibujadorEstrella(this);
        }
    }
}