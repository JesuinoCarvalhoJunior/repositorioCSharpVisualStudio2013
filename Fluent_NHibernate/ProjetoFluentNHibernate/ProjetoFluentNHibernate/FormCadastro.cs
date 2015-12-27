using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoFluentNHibernate.Repositorio;
using ProjetoFluentNHibernate.Mapeamento;
using ProjetoFluentNHibernate.Entidades;
using ProjetoFluentNHibernate.Mapeamento_Hbm;
using log4net;
using log4net.Config;

namespace ProjetoFluentNHibernate
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao.ConexaoBD.CriarTabelaBD();
           // log4net.Config.XmlConfigurator.Configure();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar_Departamento.CadastrarDepartamento();
                

            MessageBox.Show("Departamentos cadastrados com sucesso!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastrar_Grupo.CadastrarGrupo();
            MessageBox.Show("Grupos cadastrados com sucesso!");
            //
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastrar_PessoaFisica.CadastrarPessoaFisica();
            MessageBox.Show("Pessoas Físicas cadastradas com sucesso!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastrar_PessoaJuridica.CadastarPessoaJuridica();
            MessageBox.Show("Pessoas Juridicas cadastradas com sucesso!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cadastrar_PF_Telefones.CadastrarPF_Com_Telefone();
            MessageBox.Show("Pessoas Fisica com Telefones cadastradas com sucesso!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cadastrar_PF_Telefones_Grupos.CadatrarPF_TelefonesGrupos();
            MessageBox.Show("Pessoas Fisica com Telefones & Grupos cadastradas com sucesso!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Deletar_PessoaFisica.DeletarPessoaFisica();
            MessageBox.Show("Pessoa Fisica deletada com sucesso!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pesquisar_PessoaFisica.PesquisaPessoaFisica();
            MessageBox.Show("Pesquisa de Pessoa Fisica com sucesso!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Criar_Mapeamento_Hbm.CriarMapeamentoHbm();
            MessageBox.Show("Mapeamentos Hbm criados com sucesso!");
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Conexao.ConexaoBD.CriarScriptsBanco();
        }
    }
}
