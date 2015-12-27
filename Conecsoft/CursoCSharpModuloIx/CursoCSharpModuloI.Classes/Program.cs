using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(50);
            conta.Numero = 546;
            //conta.saldo = 800000;

            //if (conta.Sacar(600))
            //{
            //    Console.WriteLine("Saque realizado com sucesso");
            //    Console.WriteLine("Saldo atual {0}", conta.saldo);
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente");
            //    Console.WriteLine("Saldo atual {0}", conta.saldo);
            //}

            //Console.WriteLine("------------------------------------------");

            //if (conta.Sacar(100))
            //{
            //    Console.WriteLine("Saque realizado com sucesso");
            //    Console.WriteLine("Saldo atual {0}", conta.saldo);
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente");
            //    Console.WriteLine("Saldo atual {0}", conta.saldo);
            //}

            Console.ReadKey();
        }
    }
}
