using PROJETOMODELODDD.DOMINIO.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace PROJETOMODELODDD.INFRA.DADDOS.EntityConfig
{

    // classe para setar algumas confiracoes especifica da tabela CLIENTE
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        // utiizamos Fluent API pra mapeamento
        public ClienteConfiguration()
        {
            // reforca  qe  cliente tem PK
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);  // quando setado o tamanho - 50 , senao pega o tamanho definido em ProjetoModeloDDDContexto

            Property(c => c.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsRequired();  //pega o tamanho definido em ProjetoModeloDDDContexto = 100
        }
    }
}
