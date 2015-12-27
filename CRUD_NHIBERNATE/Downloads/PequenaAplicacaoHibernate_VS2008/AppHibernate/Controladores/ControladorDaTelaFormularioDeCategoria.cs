using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Dominio;
using PrimeraAplicacaoNHibernate.Repositories;
using PrimeraAplicacaoNHibernate.Telas;

namespace PrimeraAplicacaoNHibernate.Controladores
{
    public class ControladorDaTelaFormularioDeCategoria : ControladorAbstrato, IControladorDaTelaFormularioDeCategoria
    {
        private readonly IFormularioDeCategoria _tela;
        private readonly IRepositorioCategoria _repositorio;
        private Categoria _categoriaAtual;

        public ControladorDaTelaFormularioDeCategoria(IFormularioDeCategoria tela)
        {
            _tela = tela;
            _repositorio = new RepositorioCategoria();
        }

        public void UsuarioClicouEmNovo()
        {
            _categoriaAtual = null;

            _tela.ConfigureEstadoDeNovoOuEditando();
        }

        public void UsuarioClicouEmEditar()
        {
            var categoria = _tela.ObtenhaItemSelecionado();

            if (categoria == null)
            {
                _tela.MostreMensagemDeAtencao("Nenhum item foi selecionado!");
                return;
            }
            
            _categoriaAtual = categoria;

            _tela.ConfigureEstadoDeNovoOuEditando();

            _tela.Descricao = _categoriaAtual.Descricao;
        }

        public void UsuarioClicouEmRemover()
        {
            var categoria = _tela.ObtenhaItemSelecionado();

            if (categoria != null)
            {
                var podeSerRemovido =_repositorio.PodeSerRemovida(categoria);
                if (!podeSerRemovido)
                {
                    _tela.MostreMensagemDeErro(
                        string.Format("Categoria {0} não pode ser removida, pois esta associada a uma ou mais pessoas", categoria.Descricao));

                    return;
                }

                try
                {
                    _repositorio.Remove(categoria);
                    _tela.RemovaItemDaListagem(categoria);
                }catch(Exception ex)
                {
                    _tela.MostreMensagemDeErro("Não foi possível salvar");
                }
            }
            else
            {
                _tela.MostreMensagemDeAtencao("Nenhum item foi selecionado!.");
            }

            _tela.ConfigureEstadoDeListagem();
        }

        public void UsuarioSelecionouItem()
        {
            _tela.ConfigureEstadoDeItemSelecionado();
        }

        public void UsuarioClicouEmSalvar()
        {
            var erros = ValideDados();

            if(erros.Count > 0)
            {
                var arrayDeErro = ObtenhaArrayDeErros(erros);
                
                _tela.MostreMensagemDeAtencao(string.Join("\n", arrayDeErro));

                return;
            }

            try
            {
                if (_categoriaAtual == null)
                {
                    _repositorio.Add( ObtenhaDadosDaNovaCategoria() );
                }
                else
                {
                    ConfigureDadosAlteradosDaPessoaEmEdicao();
                    _repositorio.Update(_categoriaAtual);
                }

                LimpeECarregueLista();

                _categoriaAtual = null;

                _tela.LimpeCampos();
                _tela.ConfigureEstadoDeListagem();
            }
            catch(Exception ex)
            {
                _tela.MostreMensagemDeErro("Não foi possível salvar");
            }
        }

        private void ConfigureDadosAlteradosDaPessoaEmEdicao()
        {
            var categoria = ObtenhaDadosDaNovaCategoria();

            _categoriaAtual.Descricao = categoria.Descricao;
        }

        public Categoria ObtenhaDadosDaNovaCategoria()
        {
            return new Categoria { Descricao = _tela.Descricao };
        }

        private IList<string> ValideDados()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(_tela.Descricao))
                erros.Add("Descrição não pode ficar vazia.");

            return erros;
        }

        public void Inicialize()
        {
            LimpeECarregueLista();

            _tela.ConfigureEstadoDeListagem();
        }

        public void LimpeECarregueLista()
        {
            _tela.LimpeListagemDeCategorias();

            var lista = _repositorio.GetList();

            _tela.PreenchaListaComCategorias(lista);
        }
    }
}