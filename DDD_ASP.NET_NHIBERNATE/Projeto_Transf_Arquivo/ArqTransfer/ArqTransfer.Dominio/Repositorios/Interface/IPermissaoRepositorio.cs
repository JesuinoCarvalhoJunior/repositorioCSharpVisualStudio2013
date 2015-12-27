using System.Collections.Generic;
using ArqTransfer.Dominio.Entidades;

namespace ArqTransfer.Dominio.Repositorios.Interface
{
    public interface IPermissaoRepositorio : IRepositorioBase<Permissao>
    {

        // Retorna todas as permissões de
        // um determinado usuário
        IList<Permissao> RetornaPermissaosDoUsuario(long userId);


        // Retorna a permissão de um usuário
        // em uma pasta
        Permissao RetornaPermissaoProUsuarioEPasta(long userId, long pastaId);
        
    }
}
