using System;

namespace PrimeraAplicacaoNHibernate.Dominio
{
    public class Categoria
    {
        public virtual Guid Id { get; set;}
        public virtual string Descricao { get; set; }

        public override string  ToString()
        {
            return Descricao;
        }
    }
}
