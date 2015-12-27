using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Configuracao
{
    public class ClienteConfiguracao : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguracao()
        {
            // chave primaria
            this.HasKey(t => t.id);


            // propriedades
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.endereco)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.bairro)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.cidade)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.uf)
                .IsRequired()
                .HasMaxLength(2);

            // tabela e mapeamento
            // estudo = BD
            // cliente = tabela
            this.ToTable("cliente", "estudo");
            this.Property(t => t.id).HasColumnName("COD_CLIENTE");
            this.Property(t => t.id).HasColumnName("CLI_NOME");
            this.Property(t => t.id).HasColumnName("CLI_EMAIL");
            this.Property(t => t.id).HasColumnName("COD_ENDERECO");
            this.Property(t => t.id).HasColumnName("COD_BAIRRO");
            this.Property(t => t.id).HasColumnName("COD_CIDADE");
            this.Property(t => t.id).HasColumnName("COD_UF");
        }
    }
}
