using System;
using System.Linq;
using System.Data.Entity;
using PROJETOMODELODDD.DOMINIO.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Remoting.Messaging;
using PROJETOMODELODDD.INFRA.DADDOS.EntityConfig;


namespace PROJETOMODELODDD.INFRA.DADDOS.Contexto
{
    public class ProjetoModeloDDDContexto : DbContext
    {

        public ProjetoModeloDDDContexto()
            // nome da string de conexao = ProjetoModleoDDD
            : base("ProjetoModeloDDD")
        {


        }

        // nome das tabelas a serem criadas quando criar o contexto
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // desabilita a criacao de nome de tabelas no plural
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // desabilita exclusao em cascata na relacao 1 pra muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // desabilita exclusao em cascata na relacao muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // o entityframework entende qe todas as propriedades com nome Id é uma chave primaria,
            // e as vezes criamos chave primarica com nome composto Ex: NomeId e neste caso o 
            // o entity as vezes nao consegue interpretar e setar como um chave primaria
            // para resolver esse "problema" iremos forcar a interpretacao dos nomes composto
            // Ex: NomeId, ProdutoId e etc.

            modelBuilder.Properties()
                // usando expressao lambida concatenamos o nome
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                // atribuimos como PK
                .Configure(p => p.IsKey());

            // por padrão os campos string sao criado como nvachar(max) 
            // porem a vezes queremos campos com tamanhos diferentes, Ex: varchar 20, varchar 50, etc
            // para isso  definimos o tipo (string) para (varchar)

            modelBuilder.Properties<string>()
              .Configure(p => p.HasColumnType("varchar"));

            // aqui definimos o tamanho 
            // quando nao informarmos o valor no mapeamento o tamanho defaul será 100
            // ou seja, por padrao (string = tipo varchar e tamanho = 100)
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // instanciamos para podermos usar as propriedades personalizadas
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        // atribuimos a data automaticamente para o campo DataCadastro
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                // se esta criado o cadastro seta data atual
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                // se estiver modificando/atualizando o cadastro  não altera a data
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }

        }
            return base.SaveChanges();
        }
    }
}
