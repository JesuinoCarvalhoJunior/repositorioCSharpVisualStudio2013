using System;
using System.Web;
using ArqTransfer.Dominio.Entidades;
using ArqTransfer.Dominio.ObjetosValor;

namespace ArqTransfer.WebForms.Util
{
    public class Sessao
    {
        public static bool IsLogged
        {
            get
            {
                return (
                    HttpContext.Current.Session["IsLogged"] == null) ?
                    false :
                    Convert.ToBoolean(HttpContext.Current.Session["IsLogged"]);
            }
            set
            {
                HttpContext.Current.Session["IsLogged"] = value;
            }
        }

        public static Usuario UsuarioLogado
        {
            get
            {
                return (
                    HttpContext.Current.Session["UsuarioLogado"] == null) ?
                    null :
                    (Usuario)HttpContext.Current.Session["UsuarioLogado"];
            }
            set
            {
                HttpContext.Current.Session["UsuarioLogado"] = value;
            }
        }

        public static Pasta PastaAtual
        {
            get
            {
                return (
                    HttpContext.Current.Session["PastaAtual"] == null) ?
                    null :
                    (Pasta)HttpContext.Current.Session["PastaAtual"];
            }
            set
            {
                HttpContext.Current.Session["PastaAtual"] = value;
            }
        }

        public static Permissao PermissaoPastaAtual
        {
            get
            {
                return (
                    HttpContext.Current.Session["PermissaoPastaAtual"] == null) ?
                    null :
                    (Permissao)HttpContext.Current.Session["PermissaoPastaAtual"];
            }
            set
            {
                HttpContext.Current.Session["PermissaoPastaAtual"] = value;
            }
        }

        public static ConteudoPasta ConteudoSelecionado
        {
            get
            {
                return (
                    HttpContext.Current.Session["ConteudoSelecionado"] == null) ?
                    null :
                    (ConteudoPasta)HttpContext.Current.Session["ConteudoSelecionado"];
            }
            set
            {
                HttpContext.Current.Session["ConteudoSelecionado"] = value;
            }
        }
    }
}