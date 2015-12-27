using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    public class Servico
    {

        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataContratacao { get; set; }


        public Servico()
        {
            Console.WriteLine("Construtor da classe Servico");
            Console.ReadKey();
        }



        public virtual decimal CalcularTaxa()
        {
            return 5;
        }


    }
}
