using FluentNHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    /// <summary>
    /// a função HasMany para configurar que a entidade Departamento
    /// tem uma referência de um para muitos com a entidade Pessoa
    /// </summary>
    public class DepartamentoMap : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Id(x => x.Codigo).GeneratedBy.Identity();

            Map(x => x.Nome)
                .Not.Nullable()
                .Length(80);

            Map(x => x.Descricao)
                .Length(100);

            Map(x => x.DataCadastro)
                .Not.Nullable();

            HasMany(m => m.Pessoas);
                
        }
    }
}
