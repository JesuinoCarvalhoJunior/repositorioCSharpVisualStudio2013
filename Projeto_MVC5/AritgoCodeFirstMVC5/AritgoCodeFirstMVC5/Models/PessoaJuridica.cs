namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaJuridica")]
    public partial class PessoaJuridica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pessoa_id { get; set; }

        [Required]
        [StringLength(18)]
        public string Cnpj { get; set; }

        [StringLength(100)]
        public string WebSite { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
