using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DIA 06/08/2024
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja bemvindo(a) {0}", nome);
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if(idade >= 18)
            {
                Console.WriteLine("Você PODE votar!");
            }
            else if (idade >= 16)
            {
                Console.WriteLine("Você DEVE votar!");
            }
            else
            {
                Console.WriteLine("Você NÃO pode votar!");
            }
            // Altere o código anterior para que exiba as mensagens de acordo com a idade:
            // >= 18 : vc deve votar
            // >= 16 : vc pode votar
            // < 16 : vc não pode votar
            int[] multiplos = new int[10];
            int cont = 0;
            for(int i = 2; i < idade/2; i++)
            {
                if (idade % i == 0)
                {
                    multiplos[cont] = i;
                    cont++;
                }
            }
            foreach(int mult in multiplos) 
            {
                if( mult != 0 ) 
                {
                    Console.Write(mult + " ");
                }
            }
            // DIA 12/08/2024
            

        }
    }
}
