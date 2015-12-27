using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Entidades
{
    public class Categoria
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }

        /// <summary>
        /// <Produto> = tabela
        /// Produtos = nome da lista
        /// </summary>
        public virtual IList<Produto> Produtos { get; set; }

    }
}


