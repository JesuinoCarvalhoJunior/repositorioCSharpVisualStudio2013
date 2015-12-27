using FluentNHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    public class GrupoMap : ClassMap<Grupo>
    {
        /// <summary>
        /// a função HasManyToMany para configurar que a entidade Grupo 
        /// tem uma referência de muitos para muitos com a entidade Pessoa
        /// </summary>
        public GrupoMap()
        {

            Id(x => x.Codigo).GeneratedBy.Identity();

            Map(x => x.Nome)
                .Not.Nullable()
                .Length(80);
            Map(x => x.Descricao)
                .Length(100);

            Map(x => x.DataCadastro)
                .Not.Nullable();

            HasManyToMany(x => x.Pessoa);
        }
    }
}
