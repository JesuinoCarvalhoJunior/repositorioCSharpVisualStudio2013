using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{

    // classe abastrata nao pode ser instancia
    // Ex: conta conta = new Conta();
    public abstract class Conta
    {
        public DateTime DataAniversario { get; set; }


        public abstract void ImprimirExtrato();
    }
}
