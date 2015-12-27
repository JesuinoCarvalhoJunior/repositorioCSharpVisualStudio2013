using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    public class ContaPoupanca : Conta
    {


        public override void ImprimirExtrato()
        {
           Console.WriteLine("--- Extrato Conta Poupanca ---");
        }
    }
}
