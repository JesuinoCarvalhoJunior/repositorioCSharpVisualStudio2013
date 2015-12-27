namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados1")
        {
        }

        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Pessoa)
                .WithRequired(e => e.Departamento)
                .HasForeignKey(e => e.Departamento_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.Pessoa)
                .WithMany(e => e.Grupo)
                .Map(m => m.ToTable("GruposToPessoa").MapLeftKey("Grupo_id").MapRightKey("Pessoa_id"));

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.PessoaJuridica)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Telefone)
                .WithOptional(e => e.Pessoa)
                .HasForeignKey(e => e.Pessoa_id);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.PessoaFisica)
                .WithRequired(e => e.Pessoa);
        }
    }
}
