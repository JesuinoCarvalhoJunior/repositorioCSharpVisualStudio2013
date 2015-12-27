using System;
using ArqTransfer.WebForms.Util;

namespace ArqTransfer.WebForms
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        // Expondo o nome da Pasta para poder ser atualizado
        public string NomePasta
        {
            set { lblPasta.Text = value; }
            get { return lblPasta.Text; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Verificando se o usuário está logado                
                if (Sessao.IsLogged)
                {
                    // Exibindo nome e email do usuário Logado
                    lblLoginName.Text = string.Format("Usuário: {0} [{1}] - ",
                        Sessao.UsuarioLogado.Nome,
                        Sessao.UsuarioLogado.Email);
                }

                // Habilitando controles de Login de se o usuário estiver logado
                lblLoginName.Visible = btnLogout.Visible = Sessao.IsLogged;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Rotina de Logout
            string script = "<script type=text/javascript>";
            script += "if( confirm('";
            script += "Deseja realmente sair?";
            script += "') )";
            script += "window.location='Logout.ashx';";
            script += "</script>";
            Page.ClientScript.RegisterStartupScript(GetType(), "CloseScript", script);
        }
    }
}
