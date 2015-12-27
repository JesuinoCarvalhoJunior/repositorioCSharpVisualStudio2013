using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETOMODELODDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {

        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Informe o o nome do Produto")]
        [MaxLength(80, ErrorMessage = "O tamano máximo é {0} caracteres")]
        [MinLength(2, ErrorMessage = "O tamano mínimo pé {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Informe o valor do produto")]
        public decimal Valor { get; set; }
        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }

        // referencia da viewmodelCliente
        public virtual ClienteViewModel Cliente { get; set; }
    }
}