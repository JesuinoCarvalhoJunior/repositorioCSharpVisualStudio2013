using CursoCSharpModuloII.NHibernate.Dominio;
using FluentNHibernate.Mapping;

namespace CursoCSharpModuloII.NHibernate.Dados.Mapeamento
{
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Not.LazyLoad();

            Id(c => c.Id).GeneratedBy.Native();

            Map(c => c.Codigo)
               .Length(20)
                .Not.Nullable();

            Map(c => c.Descricao)
                .Length(100)
                .Not.Nullable();
        }
    }
}
