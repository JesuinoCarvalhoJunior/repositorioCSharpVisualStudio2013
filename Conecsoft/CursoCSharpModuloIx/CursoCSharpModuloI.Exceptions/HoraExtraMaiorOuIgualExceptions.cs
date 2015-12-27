using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Exceptions
{
    public class HoraExtraMaiorOuIgualExceptions : Exception
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
        }


        public HoraExtraMaiorOuIgualExceptions()
            : base("A quantidade de horas deve ser maior igual a Zero")
        {
            codigo = " codigo errO X01";
        }


    }
}
