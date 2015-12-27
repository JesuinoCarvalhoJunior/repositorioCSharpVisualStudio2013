using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Exceptions
{
    public class Funcionario
    {

        public decimal CalcularHoraExtra(decimal quantidadehroas)
        {
            if (quantidadehroas < 0)
            {
                throw new HoraExtraMaiorOuIgualExceptions();
            }
            return quantidadehroas * 50;
        }

    }
}
