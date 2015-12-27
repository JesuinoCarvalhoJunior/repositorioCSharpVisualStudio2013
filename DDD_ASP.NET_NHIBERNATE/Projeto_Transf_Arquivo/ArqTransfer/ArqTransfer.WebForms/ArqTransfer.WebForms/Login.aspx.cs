using System;
using ArqTransfer.Dominio.Servicos;
using ArqTransfer.Repositorio.Repositorios;
using ArqTransfer.WebForms.Util;

namespace ArqTransfer.WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Injetando o Repositório no Serviço de Domínio
            var service = new UsuarioServico(new UsuarioRepositorio());
            var usuario = service.LoginUsuario(txtUserEmail.Text, txtUserPassword.Text);
            lblMsg.Text = Funcoes.TrataMensagens(service.MensagensUsuarioServicoList);

            // Login Realizado com sucesso!
            if (usuario != null)
            {
                Sessao.IsLogged = true;
                Sessao.UsuarioLogado = usuario;

                Response.Redirect("Pastas.aspx");
            }
        }
    }
}
