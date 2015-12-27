using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOMODELODDD.DOMINIO.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        
        //propreidade  Virtual do tipo Cliente para Lazzy Load poder sobrescrever
        public virtual Cliente Cliente { get; set; }
    }
}
