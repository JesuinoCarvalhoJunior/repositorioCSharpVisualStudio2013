using FluentNHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    /// <summary>
    /// a classe PessoaFisica herda de Pessoa, em nosso mapeamento tem os que herdar de SubclassMap
    /// </summary>
    public class PessoaFisicaMap : SubclassMap<PessoaFisica>
    {
        public PessoaFisicaMap()
        {

            Map(x => x.Cpf)
                .Not.Nullable()
                .Length(14);

            Map(x => x.Nacionalidade)
                .Length(30);
        }
    }
}
