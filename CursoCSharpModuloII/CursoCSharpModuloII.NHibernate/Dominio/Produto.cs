using CursoCSharpModuloII.NHibernate.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpModuloII.NHibernate.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoFabricacao { get; set; }
        public string Nome { get; set; }
        //    public Categoria Categoria { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Marca Marca { get; set; }
        public decimal Peso { get; set; }
        public IList<ProdutoComponente> Componentes { get; set; }

        public IList<Categoria> Categorias { get; set; } 
    }
}
