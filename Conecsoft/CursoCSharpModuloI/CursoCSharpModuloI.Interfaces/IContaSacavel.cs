using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloI.Interfaces
{
    interface IContaSacavel : IConta
    {
        bool Sacar(decimal valor);
    }
}
