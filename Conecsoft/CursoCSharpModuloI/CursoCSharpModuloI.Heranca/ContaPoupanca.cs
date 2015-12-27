using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Heranca
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("--- EXTRADO CONTA POUPANÇA ----- ");
        }
    }
}
