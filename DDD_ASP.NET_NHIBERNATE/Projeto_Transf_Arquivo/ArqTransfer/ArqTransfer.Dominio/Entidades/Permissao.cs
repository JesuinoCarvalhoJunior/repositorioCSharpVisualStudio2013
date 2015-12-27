using ArqTransfer.Dominio.Entidades.Interface;

namespace ArqTransfer.Dominio.Entidades
{
    public class Permissao : IEntidade
    {

        public virtual long Id{ get; private set; }
        public virtual Pasta Pasta { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual bool PodeSubirArquivo { get; set; }
        public virtual bool PodeApagarArquivo { get; set; }

    }
}
