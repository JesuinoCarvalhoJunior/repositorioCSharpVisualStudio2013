using System;

namespace ArqTransfer.Dominio.ObjetosValor
{

    [Serializable()]
   public class ConteudoPasta
    {
        public TipoConteudo Tipo { get; set; }

        public string Nome { get; set; }


    }

    public enum TipoConteudo { Pasta = 0, Arquivo = 2}

}
