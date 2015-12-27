using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Operadores.Relacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 10;
            bool eMaiorDeIdade = idade > 17;
            bool eMenorDeIdade = idade < 18;

            Console.WriteLine("É maior de idade: {0}", eMaiorDeIdade);
            Console.WriteLine("É menor de idade: {0}", eMenorDeIdade);

            decimal salario = 1000;
            bool ganhaBem = salario >= 1000;
            bool ganhaMal = salario <= 999;

            decimal valor1 = 10;
            decimal valor2 = 20;
            bool eDiferente = valor1 != valor2;

            Console.WriteLine("Ganha bem: {0}", ganhaBem);
            Console.WriteLine("Ganha mal: {0}", ganhaMal);
            Console.ReadKey();
        }
    }
}
