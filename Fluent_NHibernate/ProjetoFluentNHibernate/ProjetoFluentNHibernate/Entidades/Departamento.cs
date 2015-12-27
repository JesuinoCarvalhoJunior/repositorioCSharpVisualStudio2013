using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{

    /// <summary>
    /// A classe Departamento tem uma relação com a classe Pessoa de 1..*,
    /// por esse motivo na classe Departamento criamos uma lista de Pessoas
    /// </summary>

   public class Departamento
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IList<Pessoa> Pessoas { get; set; }

        public Departamento()
        {
            this.Pessoas = new List<Pessoa>();
        }

    }
}
