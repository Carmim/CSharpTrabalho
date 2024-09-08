using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Triangulos
    {
        public static string VerTipoDoTriangulo(decimal lado1, decimal lado2, decimal lado3)
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
                //|| lado1 + lado2 <= lado3
                //|| lado2 + lado3 <= lado1
                //|| lado1 + lado3 <= lado2)
            {
                throw new ArgumentException(" Os numeros inseridos não formam um triangulo");
            }
            else
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "Equilátero";
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    return "Isósceles";
                }
                else
                {
                    return "Escaleno";
                }
            }
        }
    }
}

