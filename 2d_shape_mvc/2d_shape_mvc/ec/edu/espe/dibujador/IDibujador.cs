using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.dibujador
{
    internal interface IDibujador
    {

        void dibujarFigura(Graphics g, int w, int h);

    }
}
