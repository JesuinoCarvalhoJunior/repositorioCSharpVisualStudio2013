using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PrimeraAplicacaoNHibernate.Controladores;
using PrimeraAplicacaoNHibernate.Dominio;
using PrimeraAplicacaoNHibernate.Repositories;
using PrimeraAplicacaoNHibernate.Telas;

namespace PrimeraAplicacaoNHibernate
{
    public partial class FormularioDePessoa : FormularioBasico, IFormularioDePessoa
    {
        private readonly IControladorDaTelaFormularioDePessoa _controlador;

        public FormularioDePessoa()
        {
            _controlador = new ControladorDaTelaFormularioDePessoa(this);

            InitializeComponent();
            
            _controlador.Inicialize();
        }

        #region Eventos
        private void btNovo_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmNovo();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmSalvar();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmRemover();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            _controlador.UsuarioClicouEmEditar();
        }
        #endregion

        public void CarregueListaCategorias(ICollection<Categoria> listaDeCategorias)
        {
            cbCategorias.Items.Clear();

            foreach (var categoria in listaDeCategorias)
                cbCategorias.Items.Add(categoria);
        }

        private void HabiliteAdicaoOuEdicao(bool habilitar)
        {
            btSalvar.Enabled = habilitar;
            txtNome.Enabled = habilitar;
            txtSobrenome.Enabled = habilitar;
            txtDataNascimento.Enabled = habilitar;
            cbCategorias.Enabled = habilitar;
            rbSexoMasculino.Enabled = habilitar;
            rbSexoFeminino.Enabled = habilitar;

            txtNome.Focus();
        }

        public void LimpeListagemDePessoas()
        {
            ListaDePessoas.Items.Clear();
        }

        public void PreenchaListaComPessoas(ICollection<Pessoa> listaDePessoa)
        {
            foreach (var pessoa in listaDePessoa)
                ListaDePessoas.Items.Add(pessoa);
        }

        public void DesabiliteCampos()
        {
            HabiliteAdicaoOuEdicao(false);
        }

        public void HabiliteCampos()
        {
            HabiliteAdicaoOuEdicao(true);
        }

        public Pessoa ObtenhaItemSelecionado()
        {
            return (Pessoa)ListaDePessoas.SelectedItem;
        }

        public void LimpeCampos()
        {
            cbCategorias.SelectedIndex = -1;
            txtDataNascimento.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            rbSexoMasculino.Checked = true;
            rbSexoFeminino.Checked = false;
        }

        public void RemovaItemDaListagem(Pessoa pessoa)
        {
            ListaDePessoas.Items.Remove(pessoa);
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

        public string Nome
        {
            get { return txtNome.Text.Trim(); }
            set { txtNome.Text = value; }
        }

        public string Sobrenome
        {
            get { return txtSobrenome.Text.Trim(); }
            set { txtSobrenome.Text = value; }
        }

        public string DataNascimento
        {
            get { return txtDataNascimento.Text.Trim().Replace("/  /", string.Empty); }
            set { txtDataNascimento.Text = value; }
        }

        public bool Sexo
        {
            get { return rbSexoMasculino.Checked ? true : false; }
            set
            {
                rbSexoMasculino.Checked = value;
                rbSexoFeminino.Checked = !value;
            }
        }

        public Categoria Categoria
        {
            get { return (Categoria)cbCategorias.SelectedItem; }
            set
            {
                for (var i = 0; i < cbCategorias.Items.Count; i++)
                {
                    if (((Categoria)cbCategorias.Items[i]).Id != value.Id)
                        continue;

                    cbCategorias.SelectedIndex = i;

                    break;
                }
            }
        }

        private void ListaDePessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controlador.UsuarioSelecionouItem();
        }
    }
}
