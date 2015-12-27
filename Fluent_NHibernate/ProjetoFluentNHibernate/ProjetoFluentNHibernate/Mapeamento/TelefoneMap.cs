using FluentNHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    /// <summary>
    /// a função References para configurar a entidade Telefone 
    /// tem uma refência de com a entidade Pessoa
    /// </summary>
    public class TelefoneMap : ClassMap<Telefone>
    {

        public TelefoneMap()
        {

            Id(x => x.Codigo).GeneratedBy.Identity();

            Map(x => x.CodigoDdd)
                .Not.Nullable()
                .Length(11);

            Map(x => x.Numero)
                .Not.Nullable();
            
            References(x => x.Pessoa).Column("ProdutoId").Not.Nullable();


        }

    }
}
