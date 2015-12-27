using System.Collections.Generic;

namespace CursoCSharpModuloII.ADONET.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoFabricacao { get; set; }
        public string NomeProduto { get; set; }
       // public IList<Categoria> Categorias { get; set; }

        public string Categoria { get; set; }
        public double Peso { get; set; }


        public Produto()
        {
            List<Categoria> categorias = new List<Categoria>();
        }
    }
}

