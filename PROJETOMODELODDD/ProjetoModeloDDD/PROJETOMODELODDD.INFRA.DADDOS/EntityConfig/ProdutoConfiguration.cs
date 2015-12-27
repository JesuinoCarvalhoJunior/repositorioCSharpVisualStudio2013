using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETOMODELODDD.DOMINIO.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace PROJETOMODELODDD.INFRA.DADDOS.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {

        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(80);

            Property(p => p.Valor)
                .IsRequired();

            // relacionamento entre as tabelas
            // Cliente e Produto
            // 1 cliente poderá ter N produtos

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
