using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IConta conta = new ContaCorrente();
            conta.ImprimirExtrato();

            IExemplo teste = new ContaCorrente();
            teste.ImprimirExtrato();

            Console.ReadKey();
        }
    }
}
