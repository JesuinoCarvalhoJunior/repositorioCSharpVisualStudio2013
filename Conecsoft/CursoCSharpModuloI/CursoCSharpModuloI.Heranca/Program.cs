using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaPoupanca();
            
            // Tipo 1 de Conversãp
            Console.WriteLine(((ContaPoupanca)conta).DataAniversario);
            
            // Tipo 2 de conversao
            ContaPoupanca contaPoupanca = (conta as ContaPoupanca);

            //Console.WriteLine(.DataAniversario);
            

            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            //cc.ImprimirExtrato();
            //cp.ImprimirExtrato();

            Console.ReadKey();
        }
    }
}
