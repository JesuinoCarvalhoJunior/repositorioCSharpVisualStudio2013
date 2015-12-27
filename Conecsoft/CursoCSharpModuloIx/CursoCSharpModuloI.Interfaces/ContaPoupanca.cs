using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Interfaces
{
    class ContaPoupanca : IContaSacavel
    {
        public bool Sacar(decimal valor)
        {
            return true;
        }

        public void ImprimirExtrato()
        {
            throw new NotImplementedException();
        }
    }
}
