using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Model.Cliente
{
    public class ClienteModel
    {
        // Data Annotations
        [Key]  //// indica o id da tabela
        public int id { get; set; }
        public string nome { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido!")] // EmailAddress = valida o email
        public string email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data inválida")] // formatacao do campo data
        public DateTime DataNascimento { get; set; }

    }
}