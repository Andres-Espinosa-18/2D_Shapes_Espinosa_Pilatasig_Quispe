using _2d_shape_mvc.ec.edu.espe.dibujador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.modelo
{
    internal interface IFigura
    {
        double calcularArea();
        double calcularPerimetro();
        IDibujador crearDibujador();
    }
}
