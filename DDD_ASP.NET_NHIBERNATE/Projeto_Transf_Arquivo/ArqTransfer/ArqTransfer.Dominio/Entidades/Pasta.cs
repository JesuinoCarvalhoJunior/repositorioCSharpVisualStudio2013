using ArqTransfer.Dominio.Entidades.Interface;
using ArqTransfer.Dominio.ObjetosValor;


namespace ArqTransfer.Dominio.Entidades
{
    public class Pasta : IEntidade
    {

        public virtual long Id { get; private set; }

        public virtual string Caminho { get; set; }

        public virtual Pasta PastaPai { get; set; }

        // Propriedade para retornar o
        // caminho da pasta pai,
        // utilizando o Objeto de
        // Valor PastaRaiz
        public string CaminhoPai
        {
            // A propriedade CaminhoPai da entidade Pasta possui apenas um get, 
            //que irá retornar o caminho da PastaPai caso este não seja nulo, ou o caminho da PastaRaiz, 
            //caso a PastaPai seja nula.
            get
            {
                // retorno o caminho da se PastaPai for diferente de nulo
                // ou caminho da PastaRaiz se PastaPai foi nulo
                return PastaPai == null ? 
                    PastaRaiz.Caminho : PastaPai.Caminho;
            }
        }


    }
}
