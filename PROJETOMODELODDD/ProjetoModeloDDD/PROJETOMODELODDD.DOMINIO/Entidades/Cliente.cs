using System;

namespace PROJETOMODELODDD.DOMINIO.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }


       // public virtual IEquatable<Produto> Produtos { get; set; }

        // valida se é cliente especial
        // para ser especial deverá ter + 5 anos de cadastro
        // somente essa regra de negocio presente nesta unicamente nesta entidade é qe 
        // poderá dizer se o cliente é ou nao especial.
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

    }
}
