namespace AritgoCodeFirstMVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefone")]
    public partial class Telefone
    {
        [Key]
        public int Codigo { get; set; }

        public int CodigoDdd { get; set; }

        public int Numero { get; set; }

        public int? Pessoa_id { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
