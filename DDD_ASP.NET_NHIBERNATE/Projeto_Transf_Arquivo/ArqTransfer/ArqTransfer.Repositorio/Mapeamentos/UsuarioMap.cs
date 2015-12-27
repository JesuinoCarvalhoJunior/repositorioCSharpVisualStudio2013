using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ArqTransfer.Dominio.Entidades;

namespace ArqTransfer.Repositorio.Mapeamentos
{
   public class UsuarioMap : ClassMap<Usuario>
    {
       public UsuarioMap()
       {
           Id(u => u.Id).GeneratedBy.Identity();
           Map(u => u.Email).
               Not.Nullable().
               Length(80);
           Map(u => u.Senha).
               Not.Nullable().
               Length(10);

           Map(u => u.Nome).
               Not.Nullable().
               Length(50);

           Map(u => u.PodeCriarPasta).
               Length(1).
               Not.Nullable();

           Table("Usuario");

           // comentario //
           //public virtual long id { get; private set; }
           // public virtual string email { get; set; }
           // public virtual string senha { get; set; }
           //public virtual string nome { get; set; }
           //public virtual bool podecriarpasta { get; set; }

       } 


    }
}
