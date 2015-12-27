using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Heranca
{
    public class ContaCorrente : Conta
    {
        public override void ImprimirExtrato()
        {
            Console.WriteLine("--- EXTRADO CONTA CORRENTE ----- ");
        }
    }
}
