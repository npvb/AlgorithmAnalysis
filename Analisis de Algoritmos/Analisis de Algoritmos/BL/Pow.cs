using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Analisis_de_Algoritmos.BL
{
    class Pow
    {
        public BigInteger MyPow(BigInteger numero, int potencia)
        {
            BigInteger y = 1;
            int count = 0;
            if (potencia == 0) 
            {
                y = 1;
            }
            else if (potencia == 1) 
            {
                y = numero;

            }else

                while (count < potencia)
                {
                    y = numero * y;
                    count++;
                }
            return y;

        }
    }

}
