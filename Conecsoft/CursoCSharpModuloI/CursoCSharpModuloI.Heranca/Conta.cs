using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Heranca
{
    public abstract class Conta
    {
        public string Numero { get; set; }
        public abstract void ImprimirExtrato();
    }
}
