using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancia da classe Emprestimo
            // Emprestimo emprestimo = new Emprestimo();
            //emprestimo.Cliente.NomeCliente = "Jr";

            //contacorrente cc = new contacorrente();
            //contapoupanca cp = new contapoupanca();


            //cc.imprimirextrato();
            //cp.imprimirextrato();


            Conta conta = ContaPoupanca();

            // primeito tipo de conversao
            Console.ReadKey(((ContaPoupanca)conta).DataAniversario);

            // segunto tipo de conversao

            ContaPoupanca contaPoupanca = (conta as ContaPoupanca);

            Console.WriteLine(contaPoupanca.DataAniversario);


            Console.ReadKey();




        }
    }
}
