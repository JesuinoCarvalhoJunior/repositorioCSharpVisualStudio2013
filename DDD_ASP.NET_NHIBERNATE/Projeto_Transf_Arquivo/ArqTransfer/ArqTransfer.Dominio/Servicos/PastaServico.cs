using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ArqTransfer.Dominio.Entidades;
using ArqTransfer.Dominio.ObjetosValor;
using ArqTransfer.Dominio.Repositorios.Interface;

namespace ArqTransfer.Dominio.Servicos
{
    public class PastaServico
    {

        // Repositorios utilizados pelo servico PastaServico
        private readonly IPastaRepositorio _pastaRepositorio;
        private readonly IPermissaoRepositorio _permissaoRepositorio;


        public List<string> MensagensPastaServicoList { get; private set; }

        // Construtor
        public PastaServico(IPastaRepositorio pastaRepositorio, IPermissaoRepositorio permissaoRepositorio)
        {
            _pastaRepositorio = pastaRepositorio;
            _permissaoRepositorio = permissaoRepositorio;

            MensagensPastaServicoList = new List<string>();


            // Verifica se a Pasta Raiz existe, e
            // caso não exista ela é criada.
            if (!Directory.Exists(PastaRaiz.Caminho)) Directory.CreateDirectory(PastaRaiz.Caminho);
        }

        public bool IncluirPasta(Pasta pastaPai, string nomePastaFilha, Usuario usuario)
        {
            // Limpa lista de mensagens

            MensagensPastaServicoList.Clear();
            //verifica se o nome da pasta é valido
            if (string.IsNullOrEmpty(nomePastaFilha))
            {
                MensagensPastaServicoList.Add("Informe o nome da pasta!");
                return false;
            }

            //Define o Caminho da nova pasta
            string caminho = pastaPai == null ? PastaRaiz.Caminho : pastaPai.Caminho;

            caminho += "\\" + nomePastaFilha;

            // verifica se a pasta já existe
            if (Directory.Exists(caminho))
            {
                MensagensPastaServicoList.Add("Esta pasta jpa existe, escolha outro nome!");
                return false;
            }

            // cria nova pasta na Memoria
            var pasta = new Pasta { PastaPai = pastaPai, Caminho = caminho };

            try
            {
                // criando a pasta noa File System
                Directory.CreateDirectory(pasta.Caminho);
                _pastaRepositorio.Salva(pasta);

                // gravando a permissao do usuário par a pasta criada
                _permissaoRepositorio.Salva(new Permissao
                {
                    Usuario = usuario,
                    Pasta = pasta,
                    PodeApagarArquivo = true,
                    PodeSubirArquivo = true
                });

                return true;

            }
            catch (Exception ex)
            {

                MensagensPastaServicoList.Add(ex.Message);
                return false;
            }
        }


        public IList<ConteudoPasta> RetornaConteudoPastas(Pasta pasta, Usuario usuario)
        {

            // cria um alista vazia de conteudo
            IList<ConteudoPasta> conteudoPastas = new List<ConteudoPasta>();

            // incluindo referencia à pasta pai par usuario poder voltar
            if (pasta != null)
                conteudoPastas.Add(new ConteudoPasta
                {
                    Nome = pasta.CaminhoPai,
                    Tipo = TipoConteudo.Pasta
                });

            // Define o caminho da pasta atual
            string caminho = pasta == null ? PastaRaiz.Caminho : pasta.Caminho;

            // Lista todos os subdiretorios
            string[] subPastas = Directory.GetDirectories(caminho);

            // Recupernado todas s permissoes do usuario par acomprar com as pastas encontradas
            var permissaoUsuario = _permissaoRepositorio.RetornaPermissaosDoUsuario(usuario.Id);
            foreach (string subPasta in subPastas)
            {
                // exibe apenas os diretorios que o usuario tem permissao
                var permissao =
                    permissaoUsuario.
                    Where(p => p.Pasta.
                        Caminho.
                        ToUpper() == subPasta.ToUpper()).
                        SingleOrDefault();


                if (permissao != null)
                    conteudoPastas.Add(new ConteudoPasta
                    {
                        Nome = subPasta,
                        Tipo = TipoConteudo.Pasta
                    });

            }

            // Lsita todos os arquivos
            string[] arquivos = Directory.GetFiles(caminho);

            foreach (string arquivo in arquivos)
                conteudoPastas.Add(new ConteudoPasta
                {
                    Nome = arquivo,
                    Tipo = TipoConteudo.Arquivo
                });

            return conteudoPastas;

        }

        public IList<string> Mensagens { get; set; }
    }
}
