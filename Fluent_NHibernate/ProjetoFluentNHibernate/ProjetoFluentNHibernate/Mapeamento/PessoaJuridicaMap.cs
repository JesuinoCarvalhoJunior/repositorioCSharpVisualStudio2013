using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    /// <summary>
    /// a classe PessoaJuridica herda de Pessoa, em nosso mapeamento tem os que herdar de SubclassMap
    /// </summary>
    public class PessoaJuridicaMap : SubclassMap<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {

            Map(x => x.Cnpj)
                .Not.Nullable()
                .Length(18);

            Map(x => x.WebSite)
                .Length(100);
        }
    }
}
