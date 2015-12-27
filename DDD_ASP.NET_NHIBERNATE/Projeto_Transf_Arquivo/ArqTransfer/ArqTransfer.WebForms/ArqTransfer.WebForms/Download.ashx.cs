using System.Web;
using System.Web.Services;
using System.Web.SessionState;
using ArqTransfer.WebForms.Util;

namespace ArqTransfer.WebForms
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Download : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            // Pegando apenas o nome do arquivo
            var aux = Sessao.ConteudoSelecionado.Nome.Split("\\".ToCharArray());
            var fileName = aux[aux.Length - 1];

            // Forçando o Download do Arquivo
            context.Response.AppendHeader("content-disposition", "attachment; filename=" + fileName);
            context.Response.WriteFile(Sessao.ConteudoSelecionado.Nome);
            context.Response.End();

            // Retornando para a página de Pastas
            context.Response.Redirect("Pastas.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
