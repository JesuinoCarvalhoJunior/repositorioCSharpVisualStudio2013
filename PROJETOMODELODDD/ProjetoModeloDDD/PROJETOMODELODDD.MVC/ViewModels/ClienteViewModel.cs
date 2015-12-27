using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETOMODELODDD.MVC.ViewModels
{

    // viewmodels nao tem comportamento somente representacoes
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [MaxLength(50, ErrorMessage = "Tamanhp máximo é de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Tamanho minímo é de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o SobreNome")]
        [MaxLength(50, ErrorMessage = "Tamanhp máximo é de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Tamanho minímo é de {0} caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [MaxLength(100, ErrorMessage = "Tamanhp máximo é de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Informe o Email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        
        // para nao exibir/criar o campo DataCadastro quando o Scaffold foi executado
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

         public virtual IEquatable<ProdutoViewModel> Produtos { get; set; }
    }
}