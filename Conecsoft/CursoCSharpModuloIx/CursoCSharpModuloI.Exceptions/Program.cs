using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Funcionario funcionario = new Funcionario();

                funcionario.CalcularHoraExtra(-1);

            }
            catch (HoraExtraMaiorOuIgualExceptions e)
            {
                
                Console.WriteLine("Erro " + e.Codigo);
                Console.WriteLine("Erro " + e.Message);
            }

            Console.ReadKey();

        }
    }
}
