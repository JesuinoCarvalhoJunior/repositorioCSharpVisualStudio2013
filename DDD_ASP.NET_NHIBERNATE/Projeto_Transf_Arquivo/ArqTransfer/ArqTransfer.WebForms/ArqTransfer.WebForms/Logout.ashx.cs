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
    public class Logout : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            /// Finalizando a Sessão do Usuário            
            context.Session.Abandon();
            Sessao.IsLogged = false;

            /// Redirecionando para a Default.aspx
            context.Response.Redirect("Login.aspx");
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
