using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            bool resultado = false;
            int inc = 0;
            while (!resultado)
            {
                inc++;
                Console.WriteLine(inc);
            }

            do
            {
                inc++;
                Console.WriteLine(inc);

            } while (!resultado);

            Console.ReadKey();
        }

    }
}
