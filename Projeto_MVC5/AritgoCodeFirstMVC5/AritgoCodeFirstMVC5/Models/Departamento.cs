namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Departamento")]
    public partial class Departamento
    {
        public Departamento()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Pessoa> Pessoa { get; set; }
    }
}
