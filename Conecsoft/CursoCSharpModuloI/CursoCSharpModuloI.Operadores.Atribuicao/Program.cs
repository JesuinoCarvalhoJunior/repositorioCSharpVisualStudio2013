using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Operadores.Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Atribuição simples
            string nomeCurso = "Curso de .NET";
            int valor = 10;
            float salario = 750.0F;
            char caracter = 'a';

            // Atribuição de adição
            valor += 5;
            salario += 100;
            nomeCurso += " da ConecSoft *";

            // Atribuição de subtração
            valor -= 1;
            salario -= 10.5F;

            // Atribuição de divisão
            valor /= 3;
            salario /= 3;

            // Atribuição de multiplicação
            valor *= 2;
            salario *= 3;

            // Atribuição de modulo
            valor %= 2;
            salario %= 3;
            
            Console.WriteLine("Nome do curso: {0} {1}", nomeCurso, valor);
            Console.WriteLine("Valor: {0}", valor);
            Console.WriteLine("Valor fracionado: {0}", salario);
            Console.WriteLine("Caracter: {0}", caracter);
            Console.ReadKey();

            // Documentação oficial: 
            // https://msdn.microsoft.com/pt-br/library/vstudio/f6z5yhhs(v=vs.100).aspx
        }
    }
}
