using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7v2
{
    class Calculadora
    {
        float numero1;
        float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        float Suma()
        {
            return Numero1 + Numero2;
        }
        float Resta()
        {
            return Numero1 - Numero2;
        }
        float Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        float Division()
        {
            return Numero1 / Numero2;
        }

    }
}
