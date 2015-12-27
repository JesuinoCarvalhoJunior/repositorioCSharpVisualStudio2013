using FluentNHibernate.Mapping;
using ProjetoFluentNHibernate.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFluentNHibernate.Mapeamento
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        /// <summary>
        ///  Usamos um CustomType para mapear o tipo Enum
        ///  função References para configurar a entidade Pessoa possui uma refência com a entidade Departamento 
        ///  função HasManyToMany para configurar que a entidade Pessoa tem uma referência de muitos para muitos com a entidade Grupos
        ///  função HasMany para configurar que a entidade Pessoa tem uma referência de um para muitos com a entidade Telefone. 
        ///  Também estamos usando a opção cascade que quando deletar uma pessoa vamos deletar seus telefones
        /// </summary>

        public PessoaMap()
        {

            Id(x => x.Codigo).GeneratedBy.Identity();

            Map(x => x.Nome)
                .Not.Nullable()
                .Length(80);

            Map(x => x.Endereco)
                .Length(100);
            Map(x => x.Cep)
                .Length(10);

            Map(x => x.Email)
                .Length(100);

            Map(x => x.DataCadastro)
                .Not.Nullable();

            Map(x => x.Status)
                .CustomType<int>();

            References(x => x.Departamento)
                .Not.Nullable();

            HasManyToMany(x => x.Grupos);

            HasMany(x => x.Telefones).Cascade.All();

        }
    }
}
