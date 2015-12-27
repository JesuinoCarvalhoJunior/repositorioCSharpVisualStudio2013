using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Interfaces
{
    class ContaCorrente : IContaSacavel, IContaDepositavel, IExemplo
    {
        bool IContaSacavel.Sacar(decimal valor)
        {
            throw new NotImplementedException();
        }

        void IConta.ImprimirExtrato()
        {
            Console.WriteLine("Imprimir ICOnta");
        }

        void IExemplo.ImprimirExtrato()
        {
            Console.WriteLine("Imprimir IXemplo");
        }

        public void Depositar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
