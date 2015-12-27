using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.ClassesEMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Somar(20,30);

            Console.WriteLine(Funcionario.ValorRefeicao);
            Console.WriteLine(Funcionario.ValorRefeicao);
            Console.ReadKey();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Jose da Silva";
            Console.WriteLine(funcionario.Nome);
            Console.ReadKey();
        }
    }
}
