using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Entidades
{
    /// <summary>
    /// A classe Telefone tem uma relação com a classe Pessoa de 0..1, 
    /// por esse motivo na classe Telefone criamos uma refência para a classe Pessoa
    /// </summary>
    public class Telefone
    {
        public virtual int Codigo { get; set; }
        public virtual int CodigoDdd { get; set; }
        public virtual int Numero { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
