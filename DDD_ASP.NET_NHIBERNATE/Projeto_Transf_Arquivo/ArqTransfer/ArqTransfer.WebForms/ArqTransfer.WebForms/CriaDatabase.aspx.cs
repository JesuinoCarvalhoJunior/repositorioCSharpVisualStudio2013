using System;

namespace ArqTransfer.WebForms
{
    public partial class CriaDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Esse método é responsável por criar a estrutura do banco de dados
            // Também pode ser usado se você quiser recriar toda a estrutura, 
            // útil quando houver alterações
            // CUIDADO!!! Qualquer registro pre-existente nas tabelas será excluído
            ArqTransfer.Repositorio.Helpers.NHibernateHelper.OpenSession(true);
            Response.Write("Database criado com sucesso!");
        }
    }
}
