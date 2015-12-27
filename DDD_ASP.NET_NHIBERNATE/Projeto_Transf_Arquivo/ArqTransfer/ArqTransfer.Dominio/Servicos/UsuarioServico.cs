using System.Collections.Generic;
using ArqTransfer.Dominio.Entidades;
using ArqTransfer.Dominio.Repositorios.Interface;

namespace ArqTransfer.Dominio.Servicos
{
    public class UsuarioServico
    {
        // Repositorio para persistir/recuperar as informacoes do BD

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        // Mensagem em texto para identificar o retorno das operações

        public List<string> MensagensUsuarioServicoList { get; private set; }

        // Construtor que recebe o Repositorio
        public UsuarioServico(IUsuarioRepositorio repositorio)
        {
            // Recebe o Repositório por injeção de dependência,
            // evitando o acoplamento entre o Dominio
            // e a camada de Persistência
            _usuarioRepositorio = repositorio;

            // Cria a Lista de mensagens
            MensagensUsuarioServicoList = new List<string>();
        }


        // Efetua login do usuário retornando
        // um objeto do usuário
        // caso login efetuado com sucesso
        // Retorna NULL caso Login falhe
        public Usuario LoginUsuario(string email, string senha)
        {

            MensagensUsuarioServicoList.Clear();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MensagensUsuarioServicoList.Add("Informe o Email e a Senha antes de entrar!");
                return null;
            }

            var usuario = _usuarioRepositorio.RetornaPorEmailSenha(email, senha);

            if (usuario == null)
            {
                MensagensUsuarioServicoList.Add("Credenciais inválidas!");
                return null;
            }

            MensagensUsuarioServicoList.Add("Login Válido!");
            return usuario;

        }
    }
}
