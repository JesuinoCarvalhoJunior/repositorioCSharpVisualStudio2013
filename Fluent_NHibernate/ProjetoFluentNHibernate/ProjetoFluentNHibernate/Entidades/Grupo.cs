using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{
    /// <summary>
    /// A classe Grupo também tem uma relação com a classe Pessoa de 1..*, 
    /// por esse motivo na classe Grupo também criamos uma lista de Pessoas
    /// </summary>
    public class Grupo
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IList<Pessoa> Pessoa { get; set; }

        public Grupo()
        {
            this.Pessoa = new List<Pessoa>();
        }


    }
}
