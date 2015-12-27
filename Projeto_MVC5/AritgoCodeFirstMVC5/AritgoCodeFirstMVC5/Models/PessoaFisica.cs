namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaFisica")]
    public partial class PessoaFisica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pessoa_id { get; set; }

        [Required]
        [StringLength(14)]
        public string Cpf { get; set; }

        [StringLength(30)]
        public string Nacionalidade { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
