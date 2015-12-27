using System;
using System.Collections.Generic;
using PrimeraAplicacaoNHibernate.Controladores;
using PrimeraAplicacaoNHibernate.Dominio;

namespace PrimeraAplicacaoNHibernate.Telas
{
    public partial class FormularioDeCategoria : FormularioBasico, IFormularioDeCategoria
    {
        private readonly IControladorDaTelaFormularioDeCategoria _controlador;

        public FormularioDeCategoria()
        {
            _controlador = new ControladorDaTelaFormularioDeCategoria(this);

            InitializeComponent();

            _controlador.Inicialize();
        }

        #region Eventos
        private void btNovo_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmNovo();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmEditar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmRemover();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmSalvar();
        }
        #endregion

        public void LimpeListagemDeCategorias()
        {
            ListaDeCategorias.Items.Clear();
        }

        public void PreenchaListaComCategorias(ICollection<Categoria> listaDeCategorias)
        {
            foreach (var categoria in listaDeCategorias)
                ListaDeCategorias.Items.Add(categoria);
        }

        public void DesabiliteCampos()
        {
            HabiliteAdicaoOuEdicao(false);
        }

        public void HabiliteCampos()
        {
            HabiliteAdicaoOuEdicao(true);
        }

        public void ConfigureEstadoDeListagem()
        {
            DesabiliteCampos();

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btSalvar.Enabled = false;
            btRemover.Enabled = false;
        }

        public void ConfigureEstadoDeNovoOuEditando()
        {
            HabiliteCampos();

            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btRemover.Enabled = false;
            btSalvar.Enabled = true;
        }

        public void ConfigureEstadoDeItemSelecionado()
        {
            DesabiliteCampos();

            btNovo.Enabled = true;
            btEditar.Enabled = true;
            btRemover.Enabled = true;
            btSalvar.Enabled = false;
        }

        public Categoria ObtenhaItemSelecionado()
        {
            return (Categoria)ListaDeCategorias.SelectedItem;
        }

        public void LimpeCampos()
        {
            txtDescricao.Text = string.Empty;
        }

        public void RemovaItemDaListagem(Categoria categoria)
        {
            ListaDeCategorias.Items.Remove(categoria);
        }

        private void HabiliteAdicaoOuEdicao(bool habilitar)
        {
            btSalvar.Enabled = habilitar;
            txtDescricao.Enabled = habilitar;
            txtDescricao.Focus();
        }

        public string Descricao
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }
        }

        private void ListaDeCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controlador.UsuarioSelecionouItem();
        }
    }
}