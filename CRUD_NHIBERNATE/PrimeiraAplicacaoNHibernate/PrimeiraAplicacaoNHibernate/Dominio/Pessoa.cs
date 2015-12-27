using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAplicacaoNHibernate.Dominio
{
    class Pessoa
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome {get; set;}
        public virtual string Sobrenome {get; set;}
        public virtual bool Sexo {get; set;}
        public virtual DateTime DataNascimento {get; set;}
        public virtual Categoria Categoria {get; set;}

    }
}
