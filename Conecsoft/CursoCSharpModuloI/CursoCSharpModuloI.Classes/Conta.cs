using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Classes
{
    public class Conta
    {
        private double saldo;
        public double limite;
        private int numero;

        public int Numero { get; set; }

        public Conta(int numero)
        {
            this.numero = numero;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor + CalcularTaxa(valor);
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        private double CalcularTaxa(double valor)
        {
            return valor * 0.01F;
        }

        public void ImprimirExtrato()
        {
            DateTime dataInicial = DateTime.Now.AddDays(-15);
            ImprimirExtrato(dataInicial, DateTime.Now);
        }

        public void ImprimirExtrato(int dias)
        {
            DateTime dataInicial = DateTime.Now.AddDays(dias * -1);
            ImprimirExtrato(dataInicial, DateTime.Now);
        }

        public void ImprimirExtrato(DateTime dataInicial, DateTime dataFinal)
        { 
        }
    }
}
