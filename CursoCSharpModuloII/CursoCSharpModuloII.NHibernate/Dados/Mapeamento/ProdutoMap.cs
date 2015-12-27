using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharpModuloII.NHibernate.Dominio;
using FluentNHibernate.Mapping;

namespace CursoCSharpModuloII.NHibernate.Dados.Mapeamento
{
    class ProdutoMap :ClassMap<Produto>
    {

        public ProdutoMap()
        {
            Not.LazyLoad();

            Id(c => c.Id).GeneratedBy.Native();

            References(c => c.UnidadeMedida).Column("UnidadeMedidaId").Not.Nullable();

            HasMany(c => c.Componentes).Inverse().KeyColumn("ProdutoId").Cascade.AllDeleteOrphan();

            HasManyToMany(c => c.Categorias)
                .Table("ProdutoCategoria")
                .ParentKeyColumn("ProdutoId")
                .ChildKeyColumn("CategoriaId");

            Map(c => c.CodigoFabricacao).Length(20).Not.Nullable();
            Map(c => c.Nome).Length(100).Not.Nullable();
           // Map(c => c.Categoria).Not.Nullable();
            Map(c => c.Peso).Not.Nullable();

        }
    }
}
