using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _2d_shape_mvc.ec.edu.espe.utils
{
    internal class Validacion
    {
        public bool isEmpty(string text){
            if (text == "")
                return true;
            return false;
        }

        public bool isNumbers(string text){
            double num;
            if (!double.TryParse(text, out num))
                return false;
            return true;
        }

        public bool isPositive(double number){
            return number >= 0;
        }

        public bool validarTriangulo(double l1, double l2, double l3)
        {
            if (l1 + l2 <= l3 || l1 + l3 <= l2 || l2 + l3 <= l1)
                return false;
            return true;
        }
    }
}
