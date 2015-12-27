using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.Heranca
{
    class SeguroVeiculo : Servico
    {

        public Veiculo Veiculo { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal ValorFranquia { get; set; }
    }
}
