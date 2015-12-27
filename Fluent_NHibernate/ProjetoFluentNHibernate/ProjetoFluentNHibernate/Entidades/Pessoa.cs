using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{

    public class Pessoa
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataCadastro { get; set; }

        /// <summary>
        /// Relação com a classe Status
        ///Relação de 0..1 com a classe Departamento
        ///Relação de 1..* com a classe Grupo
        ///Relação de 1..* com a classe Telefone
        /// </summary>
        public virtual Status Status { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual IList<Grupo> Grupos { get; set; }
        public virtual IList<Telefone> Telefones { get; set; }


        public Pessoa()
        {
            this.Grupos = new List<Grupo>();
            this.Telefones = new List<Telefone>();

        }

    }
}
