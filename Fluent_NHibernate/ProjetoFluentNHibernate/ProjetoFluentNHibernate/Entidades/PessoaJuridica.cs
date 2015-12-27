using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{
    /// <summary>
    /// herda da classe pai Pessoa
    /// </summary>
    public class PessoaJuridica : Pessoa
    {
        public virtual string Cnpj { get; set; }
        public virtual string WebSite { get; set; }
    }
}
