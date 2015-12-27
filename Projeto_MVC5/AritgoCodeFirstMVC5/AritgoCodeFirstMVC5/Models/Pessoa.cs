namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        public Pessoa()
        {
            Telefone = new HashSet<Telefone>();
            Grupo = new HashSet<Grupo>();
        }

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(10)]
        public string Cep { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public int? Status { get; set; }

        public int Departamento_id { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }

        public virtual ICollection<Telefone> Telefone { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }

        public virtual ICollection<Grupo> Grupo { get; set; }
    }
}
