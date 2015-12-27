using CRUD.Model.Cliente;
using System;
using System.Collections.Generic;
using System.Data.Entity; //foi add para poder usar DbContext
using System.Linq;
using System.Web;

namespace CRUD.Model.ExemploDBContext
{
    // class herda de DBContext
    public class DbContextExemplo : DbContext
    {
        public DbContextExemplo()
            : base("BDExemplo")
        {

        }
        // DbSet = representacao do tipo de colecao da classe ClienteModel
        // Cliente = Propriedade do contexto, os objetos serao manipulados por meio 
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}