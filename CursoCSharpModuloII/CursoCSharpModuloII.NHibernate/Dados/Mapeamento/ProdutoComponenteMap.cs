using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CursoCSharpModuloII.NHibernate.Dominio;

namespace CursoCSharpModuloII.NHibernate.Dados.Mapeamento
{
    class ProdutoComponenteMap : ClassMap<ProdutoComponente>
    {
        public ProdutoComponenteMap()
        {
            Id(c => c.Id).GeneratedBy.Native();

            References(c => c.Produto).Column("ProdutoId").Not.Nullable();

            Map(c => c.Descricao).Length(100).Not.Nullable();


        }
    }
}
