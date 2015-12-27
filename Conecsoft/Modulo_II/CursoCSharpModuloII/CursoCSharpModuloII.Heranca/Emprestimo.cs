using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    public class Emprestimo : Servico
    {
        public decimal Valor { get; set; }
        public decimal TaxaJuros { get; set; }


        public Emprestimo()
        {
            Console.WriteLine("Construtor da classe Emprestimo");
            Console.ReadKey();
        }


        public override decimal CalcularTaxa()
        {
            return base.CalcularTaxa() + (Valor * 0.01M);
        }
    }
}
