using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;
using ArqTransfer.Dominio.ObjetosValor;
using ArqTransfer.Dominio.Servicos;
using ArqTransfer.Repositorio.Repositorios;
using ArqTransfer.WebForms.Util;

namespace ArqTransfer.WebForms
{
    public partial class Pastas : System.Web.UI.Page
    {
        private IList<ConteudoPasta> Conteudo
        {
            set
            {
                ViewState["ConteudoPasta"] = value;
            }
            get
            {
                object o = ViewState["ConteudoPasta"];
                if (o == null) return null;
                return (IList<ConteudoPasta>)o;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Se o usuário não estiver logado, voltar ao Login
            if (!Sessao.IsLogged) Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                // Habilita botão de nova pasta apenas se o usuário possuir permissão
                btnNovaPasta.Visible = Sessao.UsuarioLogado.PodeCriarPasta;

                // Se não for PostBack, lê o conteúdo da pasta atual
                LoadContent();
            }
        }

        private void LoadContent()
        {
            var service = new PastaServico(
                new PastaRepositorio(),          // injetando repositório de pastas no serviço
                new PermissaoRepositorio());     // injetando repositório de permissões no serviço

            //Recuperando todas as pastas que o usuário tem permissão e exibindo no Grid
            Conteudo = service.RetornaConteudoPastas(Sessao.PastaAtual, Sessao.UsuarioLogado);
            gdvItens.DataSource = Conteudo;
            gdvItens.DataBind();

            // Desabilitando os controles de inclusão de novas pastas
            ExibeControlesPasta(false);

            //Limpando mensagens de erro
            lblMsg.Text = "";

            // Atualizando o nome da pasta atual na masterPage
            (Master as SiteMaster).NomePasta = Sessao.PastaAtual == null ? PastaRaiz.Caminho : Sessao.PastaAtual.Caminho;

            // Habilita controles de upload apenas se estiver em subpastas
            lblUpload.Visible = FileUpload1.Visible = btnUpload.Visible = (Sessao.PastaAtual != null);
        }

        private void ExibeControlesPasta(bool exibe)
        {
            lblNomePasta.Visible = txtNomePasta.Visible = btnSalvar.Visible = btnCancelar.Visible = exibe;
            btnNovaPasta.Visible = !exibe;
        }

        protected void btnNovaPasta_Click(object sender, EventArgs e)
        {
            ExibeControlesPasta(true);
            txtNomePasta.Text = "";
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var service = new PastaServico(
                new PastaRepositorio(),          // injetando repositório de pastas no serviço
                new PermissaoRepositorio());     // injetando repositório de permissões no serviço

            // Incluindo a nova pasta
            if (!service.IncluirPasta(Sessao.PastaAtual, txtNomePasta.Text, Sessao.UsuarioLogado))
                lblMsg.Text = Funcoes.TrataMensagens(service.Mensagens);
            else
                LoadContent();
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ExibeControlesPasta(false);
        }

        protected void gdvItens_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var conteudoPasta = (ConteudoPasta)e.Row.DataItem;

                // Se o item for arquivo, trocar imagem dé exibição
                if (conteudoPasta.Tipo == TipoConteudo.Arquivo)
                {
                    var imgButton = (ImageButton)e.Row.Cells[0].FindControl("imgPastaArquivo");
                    imgButton.ImageUrl = "~/Images/file.png";
                }

                // Verifica se o usuário pode exluir itens nesta pasta
                if (Sessao.PermissaoPastaAtual == null || !Sessao.PermissaoPastaAtual.PodeApagarArquivo)
                    e.Row.Cells[2].Visible = true;
              

                // Se for a pasta Pai,~desabilitar botão excluir
                if (Sessao.PastaAtual != null && conteudoPasta.Nome == Sessao.PastaAtual.CaminhoPai)
                    e.Row.Cells[2].Visible = true;
            }
        }

        protected void gdvItens_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Recupera linha do Grid de onde veio o comando
            var index = Convert.ToInt32(e.CommandArgument);
            if (index >= 0)
            {
                var conteudoPasta = Conteudo[index];

                // Se o usuário clicou no ícone ou nome de uma pasta
                if (e.CommandName == "PastaArquivo" && conteudoPasta.Tipo == TipoConteudo.Pasta)
                    NavegaPasta(conteudoPasta);
                else if (e.CommandName == "PastaArquivo" && conteudoPasta.Tipo == TipoConteudo.Arquivo)
                    DownloadArquivo(conteudoPasta);
                else if (e.CommandName == "Excluir")
                    ExcluirArquivo(conteudoPasta);
            }
        }

        private void NavegaPasta(ConteudoPasta conteudoPasta)
        {
            Sessao.PastaAtual = (new PastaRepositorio()).RetornaPastaporCaminho(conteudoPasta.Nome);
            if (Sessao.PastaAtual != null)
            {
                Sessao.PermissaoPastaAtual =
                    (new PermissaoRepositorio()).RetornaPermissaoPorUsuarioEPasta(
                        Sessao.UsuarioLogado.Id, Sessao.PastaAtual.Id);
            }
            else
            {
                Sessao.PermissaoPastaAtual = null;
            }
            LoadContent();
        }

        private void DownloadArquivo(ConteudoPasta conteudoPasta)
        {
            Sessao.ConteudoSelecionado = conteudoPasta;
            Response.Redirect("Download.ashx");
        }

        private void ExcluirArquivo(ConteudoPasta conteudoPasta)
        {
            // Esse nós deixamos paraa você fazer
            throw new NotImplementedException();


        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (!FileUpload1.HasFile)
                lblMsg.Text = "<li>Escolha um arquivo para realizar o download";
            else
            {
                try
                {
                    if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
                    {
                        string fn = Path.GetFileName(FileUpload1.PostedFile.FileName);
                        string caminho = Sessao.PastaAtual == null ? PastaRaiz.Caminho : Sessao.PastaAtual.Caminho;
                        string saveLocation = caminho + "\\" + fn;
                        FileUpload1.PostedFile.SaveAs(saveLocation);
                        LoadContent();
                    }
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "<li>" + ex.Message;
                }
            }
        }

        protected void gdvItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gdvItens_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}
