using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Exceptions
{
    public class Funcionario
    {
        public decimal CalcularHoraExtra(decimal quantidadeHoras)
        {
            if (quantidadeHoras < 0)
            {
                throw new HoraExtrataMaiorOuIgualAZero();
            }
            return quantidadeHoras * 50;
        }
    }
}
