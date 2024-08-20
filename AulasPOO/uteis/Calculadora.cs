using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Calculadora
    {
        public int Soma(int num1, int num2)
        {
            return  num1 + num2;
        }
        public  static int Multiplica(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Fatorial(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                return 1;
            }
            return num1 * Fatorial(num1 - 1);
        }
    }
}
