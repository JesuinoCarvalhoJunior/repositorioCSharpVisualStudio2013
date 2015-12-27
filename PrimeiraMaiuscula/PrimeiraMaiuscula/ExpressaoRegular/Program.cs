using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressaoRegular
{
    class Program
    {
        private static void Main(string[] args)
        {
            //    string input = @"ch/js/789747b7/scriptSearch.js"",videoJsSrc:""res/batch/js/3c9a6ee1/scriptVideo.js"",";
            //Match output = Regex.Match(input, @"gwtHash:""(.*?)""").Value;
            //Console.WriteLine(output);


            //   Match output = Regex.Match(input, @"gwtHash:""(.*?)""");
            //  Console.WriteLine(output.Value);


            //            Console.ReadKey();


            string frase = "hD'Àvila Gosto de Java e C#";

            int pos = frase.IndexOf('\'');

            if (pos != -1)
                Console.WriteLine("O caractere foi encontrado" +
                  " na posição " + pos);
            else
                Console.WriteLine("O caractere não foi encontrado");


            Console.ReadKey();
        }
    }
}

