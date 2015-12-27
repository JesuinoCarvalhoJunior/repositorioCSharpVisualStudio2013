using ArqTransfer.Dominio.Entidades;

namespace ArqTransfer.Dominio.Repositorios.Interface
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        //método que retorne o usuário de acordo com o email e senha que ele vai informar na página de login.

        // esse metodo sera difinado no Dominio.
        Usuario RetornaPorEmailSenha(string email, string senha);
        //
    }
}
