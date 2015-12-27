using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Exceptions
{
    public class HoraExtrataMaiorOuIgualAZero : Exception
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
        }

        public HoraExtrataMaiorOuIgualAZero()
            : base("A quantidade de horas deve ser maior ou igual a zero!")   
        {
            codigo = "ADS-123456";
        }
    }
}
