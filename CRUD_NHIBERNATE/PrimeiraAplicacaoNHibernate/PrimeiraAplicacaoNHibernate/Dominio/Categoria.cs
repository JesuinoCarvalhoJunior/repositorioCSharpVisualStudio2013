using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAplicacaoNHibernate.Dominio
{
    class Categoria
    {
        public virtual Guid Id { set; get; }
        public virtual string Descricao { get; set; }
    }
}
