using System;
using System.Text;
using PrimeraAplicacaoNHibernate.Util;

namespace PrimeraAplicacaoNHibernate.Dominio
{
    public class Pessoa
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string SobreNome { get; set; }
        public virtual bool Sexo { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual string ObtenhaDataNascimentoFormatada()
        {
            return UtilitarioDeData.ConvertaParaFormatoBrasileiro(DataNascimento);
        }

        public override string ToString()
        {
            var texto = new StringBuilder();

            texto.AppendFormat("{0} {1} - ", Nome, SobreNome)
                .AppendFormat("{0} - ", ObtenhaDataNascimentoFormatada())
                .AppendFormat("{0} - ", Sexo ? "Masculino": "Feminino")
                .AppendFormat("{0}", Categoria.Descricao);

            return texto.ToString();
        }
    }
}
