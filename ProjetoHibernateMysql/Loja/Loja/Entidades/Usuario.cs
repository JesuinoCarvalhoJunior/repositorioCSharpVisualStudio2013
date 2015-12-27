using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Entidades
{

    // classe e os atributos precisam ser publicos 
    // pra poder usar hibernate
    public abstract class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }



        public Usuario()
        {
            // TODO: Complete member initialization
        }
    }
}
