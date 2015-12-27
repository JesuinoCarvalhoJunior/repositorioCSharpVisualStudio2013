using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    public class ContaCorrente : Conta
    {
        public override void ImprimirExtrato()
        {
            Console.WriteLine("--- Extrato Conta Corrente ---");
        }
    }
}
