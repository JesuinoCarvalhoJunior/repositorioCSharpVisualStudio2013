using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.NHibernate.Dominio
{
  public  class ProdutoComponente
    {
      public int Id { get; set; }

      public Produto Produto { get; set; }

      public string Descricao { get; set; }
    }
}
