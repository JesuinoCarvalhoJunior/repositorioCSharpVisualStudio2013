using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Variaveis.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string curso = " Curso C# Modulo I ";
            string[] nomes = { "Danilo", "Alisson", "Junior", "Marcio" };
            Console.WriteLine("curso: " + curso);
            Console.WriteLine("Maiúscolo: " + curso.ToUpper());
            Console.WriteLine("Minúsculo: " + curso.ToLower());

            Console.WriteLine("Replace: " + curso.Replace("C#", ".NET"));
            Console.WriteLine("Trim: " + curso.Trim());
            Console.WriteLine("Trim End: " + curso.TrimEnd());
            Console.WriteLine("Trim Start: " + curso.TrimStart());
            Console.WriteLine("Sub String 01: " + curso.Substring(5));
            Console.WriteLine("Sub String 02: " + curso.Substring(5, 2));
            Console.WriteLine("Começa com: " + curso.StartsWith("C"));
            Console.WriteLine("Começa com: " + curso.IndexOf("M"));
            Console.WriteLine("Começa com: " + curso.LastIndexOf("o"));
            Console.WriteLine("Nomes Contanados (Join): " + string.Join(",", nomes));

            var cursoSeparado = curso.Trim().Split(' ');
            foreach (var c in cursoSeparado)
            {
                Console.WriteLine(c);
            }

            foreach (var c in curso)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(curso);
            Console.ReadKey();
        }
    }
}
