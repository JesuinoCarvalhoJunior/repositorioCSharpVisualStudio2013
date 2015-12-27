using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrimeiraMaiuscula
{
    class Program
    {

        static void Main(string[] args)
        {
            var result = Regex.Replace(" la monaca D'i  dia dos r pais estrela d'ávila ", @"\b(\w)(\w*)\b", ConverterCadaInstanciaEmMaiuscula);
            Console.WriteLine(result);


            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine(ConverterPrimeiraLetraMaiuscula("d'avila jose f fe dos santos r re da silva d'avila "));

            Console.ReadKey();
        }



        // dicionário de normalização, com chaves que são case-insensitive
        static readonly Dictionary<string, string> PalavraEspecialReservada
            = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
    {
        { "e", "e" },
        { "de", "de" },
        { "da", "da" },
        { "do", "do" },
        { "das", "das" },
        { "dos", "dos" },
    };

        private static string ConverterCadaInstanciaEmMaiuscula(Match matchPalavra)
        {

            // se for uma das palavras especiais
            string replacement;
            if (PalavraEspecialReservada.TryGetValue(matchPalavra.Value, out replacement))
                return replacement;

            // se não for uma palavra especial, faz title-case
            return matchPalavra.Groups[1].Value.ToUpper()
                   + matchPalavra.Groups[2].Value.ToLower();
        }

        //

        static string ConverterPrimeiraLetraMaiuscula(string texto)
        {

            string[] excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
            //  IList excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
            var palavras = new Queue<string>();

            string nomeAbreviado;

            foreach (var palavra in texto.Split(' '))
            {
                if (!string.IsNullOrEmpty(palavra))// ||  palavra.Length == 1 )
                {
                    nomeAbreviado = palavra;


                    //string frase = "hD'Àvila";

                    //int pos = texto.IndexOf('\'');


                    //  if (nomeAbreviado.Contains('\''))
                    //  {
                    //      nomeAbreviado = nomeAbreviado.ToUpper();
                    //  }

                    if (nomeAbreviado.Length == 1)
                    {
                        nomeAbreviado = String.Concat(palavra, ".");
                    }

                    var emMinusculo = nomeAbreviado.ToLower();
                    //var emMinusculo = palavra.ToLower();
                    var letras = emMinusculo.ToCharArray();

                    if (letras.Length == 1)
                    {
                        Convert.ToString(letras);
                        string.Concat(letras, ".");
                    }

                    if (!excecoes.Contains(emMinusculo)) letras[0] = char.ToUpper(letras[0]);
                    palavras.Enqueue(new string(letras));
                }
            }

            return string.Join(" ", palavras);

        }

    }
}
