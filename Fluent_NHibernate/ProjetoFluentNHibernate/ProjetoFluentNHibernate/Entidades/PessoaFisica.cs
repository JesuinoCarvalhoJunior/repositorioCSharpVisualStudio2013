using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{
    /// <summary>
    /// herda da classe pai Pessoa
    /// </summary>
   public  class PessoaFisica : Pessoa
    {
        public virtual string Cpf { get; set; }
        public virtual string Nacionalidade { get; set; }

    }
}
