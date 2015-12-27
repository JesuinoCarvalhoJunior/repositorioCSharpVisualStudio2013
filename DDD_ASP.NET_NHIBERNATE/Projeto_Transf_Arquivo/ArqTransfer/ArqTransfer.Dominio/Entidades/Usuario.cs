using ArqTransfer.Dominio.Entidades.Interface;

namespace ArqTransfer.Dominio.Entidades
{
    public class Usuario : IEntidade
    {
        public virtual long Id { get; private set; }
        
        public virtual string Email { get; set; }
        
        public virtual string Senha { get; set; }

        public virtual string Nome { get; set; }

        public virtual bool PodeCriarPasta { get; set; }

    }
}



