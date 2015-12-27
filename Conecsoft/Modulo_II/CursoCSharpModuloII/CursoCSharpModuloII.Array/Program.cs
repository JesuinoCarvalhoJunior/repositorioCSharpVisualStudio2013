using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Array
{
    class Program
    {
        private static void Main(string[] args)
        {
            // pode ser usado assim

            //     int[] numeros = new int[100];

            // ou assim, neste caso estou dizendo que o Array tem dois indice
            int[] numeros2 = { 10, 60, 70 };

            foreach (var i in numeros2)
            {
                Console.WriteLine(i);
                if (i < 60)
                {
                    Console.WriteLine("I vale", i);
                }
               
            }
            Console.ReadKey();

        }
    }
}

