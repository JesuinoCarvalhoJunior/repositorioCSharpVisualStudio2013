using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string curso = "Curso C# modulo I";

            Console.WriteLine("Maiuscula:" + curso.ToUpper());

            Console.WriteLine("Maiuscula:" + curso.ToLower());
            Console.WriteLine("Maiuscula:" + curso.Trim());
            Console.WriteLine("Maiuscula:" + curso.ToUpper());

            Console.WriteLine("Maiuscula:" + curso.LastIndexOf(curso));
            Console.WriteLine("Maiuscula:" + curso.CompareTo(curso));
            Console.WriteLine("Maiuscula:" + curso.Substring(3));


            Console.ReadKey();

        }
    }
}
