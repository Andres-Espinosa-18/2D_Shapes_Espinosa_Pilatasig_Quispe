using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2d_shape_mvc.ec.edu.espe.modelo;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal interface IDibujador
    {
        void dibujarFigura(Graphics g, int w, int h, Deformacion deformacion);

    }
}
