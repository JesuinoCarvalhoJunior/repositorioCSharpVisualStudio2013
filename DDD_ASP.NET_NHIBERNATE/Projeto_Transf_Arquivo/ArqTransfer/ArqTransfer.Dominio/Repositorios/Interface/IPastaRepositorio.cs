using ArqTransfer.Dominio.Entidades;

namespace ArqTransfer.Dominio.Repositorios.Interface
{
   public interface IPastaRepositorio  : IRepositorioBase<Pasta>
   {
       // retorno a Pasta atraves do caminho informado
       Pasta RetornaPastaporCaminho(string caminho);
   }
}
