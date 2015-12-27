using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Entidades
{
    public class PessoaFisica : Usuario
    {
        public virtual string CPF { get; set; }

    }
}
