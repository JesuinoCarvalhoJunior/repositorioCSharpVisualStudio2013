using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;
using PrimeraAplicacaoNHibernate.Repositories;
using PrimeraAplicacaoNHibernate.Telas;
using PrimeraAplicacaoNHibernate.Util;

namespace PrimeraAplicacaoNHibernate.Controladores
{
    public class ControladorDaTelaFormularioDePessoa : ControladorAbstrato, IControladorDaTelaFormularioDePessoa
    {
        private readonly IFormularioDePessoa _tela;
        private readonly IRepositorioCategoria _repositorioCategoria;
        private readonly IRepositorioPessoa _repositorioPessoa;
        private Pessoa _pessoaAtual;

        public ControladorDaTelaFormularioDePessoa(IFormularioDePessoa tela)
        {
            _tela = tela;
            _repositorioCategoria = new RepositorioCategoria();
            _repositorioPessoa = new RepositorioPessoa();
        }

        public void Inicialize()
        {
            LimpeECarregueLista();

            _tela.ConfigureEstadoDeListagem();
        }

        public void UsuarioClicouEmNovo()
        {
            _pessoaAtual = null;

            _tela.ConfigureEstadoDeNovoOuEditando();

            var listaDeCategorias = _repositorioCategoria.GetList();

            _tela.CarregueListaCategorias(listaDeCategorias);
        }

        public void UsuarioClicouEmEditar()
        {
            var pessoa = _tela.ObtenhaItemSelecionado();

            if (pessoa == null)
            {
                _tela.MostreMensagemDeAtencao("Nenhum item foi selecionado!");
                return;
            }

            _pessoaAtual = pessoa;

            _tela.ConfigureEstadoDeNovoOuEditando();

            _tela.Nome = _pessoaAtual.Nome;
            _tela.Sobrenome = _pessoaAtual.SobreNome;
            _tela.DataNascimento = _pessoaAtual.ObtenhaDataNascimentoFormatada();
            _tela.Sexo = _pessoaAtual.Sexo;
            _tela.Categoria = _pessoaAtual.Categoria;
        }

        public void UsuarioClicouEmRemover()
        {
            var pessoa = _tela.ObtenhaItemSelecionado();

            if (pessoa != null)
            {
                try
                {
                    _repositorioPessoa.Remove(pessoa);
                    _tela.RemovaItemDaListagem(pessoa);
                }
                catch (Exception ex)
                {
                    _tela.MostreMensagemDeErro("Não foi possível salvar pessoa");
                }
            }
            else
            {
                _tela.MostreMensagemDeAtencao("Nenhum item foi selecionado!.");
            }

            _tela.ConfigureEstadoDeListagem();
        }

        public void UsuarioClicouEmSalvar()
        {
            var erros = ValideDados();

            if (erros.Count > 0)
            {
                var arrayDeErro = ObtenhaArrayDeErros(erros);

                _tela.MostreMensagemDeAtencao(string.Join("\n", arrayDeErro));

                return;
            }

            try
            {
                if (_pessoaAtual == null)
                {
                    _repositorioPessoa.Add( ObtenhaDadosDaNovaPessoa() );
                }
                else
                {
                    ConfigureDadosAlteradosDaPessoaEmEdicao();
                    _repositorioPessoa.Update( _pessoaAtual );
                }

                LimpeECarregueLista();

                _pessoaAtual = null;

                _tela.LimpeCampos();
                _tela.ConfigureEstadoDeListagem();
            }
            catch (Exception ex)
            {
                _tela.MostreMensagemDeErro("Não foi possível salvar");
            }
        }

        private void ConfigureDadosAlteradosDaPessoaEmEdicao()
        {
            var pessoa = ObtenhaDadosDaNovaPessoa();

            _pessoaAtual.Nome           = pessoa.Nome;
            _pessoaAtual.SobreNome      = pessoa.SobreNome;
            _pessoaAtual.DataNascimento = pessoa.DataNascimento;
            _pessoaAtual.Sexo           = pessoa.Sexo;
            _pessoaAtual.Categoria      = pessoa.Categoria;
        }

        private Pessoa ObtenhaDadosDaNovaPessoa()
        {
            return new Pessoa
                       {
                           Nome             = _tela.Nome,
                           Categoria        = _tela.Categoria,
                           DataNascimento   = ObtenhaDataParaBanco(_tela.DataNascimento),
                           Sexo             = _tela.Sexo,
                           SobreNome        = _tela.Sobrenome
                       };
        }

        private static DateTime ObtenhaDataParaBanco(string dataNascimento)
        {
            return UtilitarioDeData.ConvertaParaBanco(dataNascimento);
        }

        private IList<string> ValideDados()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(_tela.Nome))
                erros.Add("Nome não pode ficar vazia.");

            if (string.IsNullOrEmpty(_tela.Sobrenome))
                erros.Add("Sobrenome não pode ficar vazia.");

            if (string.IsNullOrEmpty(_tela.DataNascimento))
                erros.Add("Data de nascimento não pode ficar vazia.");

            if (_tela.Categoria == null)
                erros.Add("Uma categoria deve ser selecionada.");

            return erros;
        }

        public void LimpeECarregueLista()
        {
            _tela.LimpeListagemDePessoas();

            var lista = _repositorioPessoa.GetList();

            _tela.PreenchaListaComPessoas(lista);
        }

        public void UsuarioSelecionouItem()
        {
            _tela.ConfigureEstadoDeItemSelecionado();
        }
    }
}