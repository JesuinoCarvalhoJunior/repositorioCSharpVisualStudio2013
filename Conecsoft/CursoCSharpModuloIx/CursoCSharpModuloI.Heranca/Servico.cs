using System;
using System.Collections;

namespace CursoCSharpModuloI.Heranca
{
    public class Servico
    {
        public Cliente Cliente { get; set; }
        public Funcinario Funcionado { get; set; }
        public DateTime DataContratacao { get; set; }

        public Servico()
        {
            Console.WriteLine("Construtor da classe Servico");
        }

        public virtual decimal CalcularTaxa()
        {
            return 5;
        }
    }
}
