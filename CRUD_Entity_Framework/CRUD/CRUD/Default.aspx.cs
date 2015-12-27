using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.Model.Cliente;
using CRUD.Model.ExemploDBContext;

namespace CRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<ClienteCrud> CarregarGrid()
        {
            var db = new ClienteCrud();
            return db.CarregaDados();
        }

        public void FormCadastro_InsertItem()
        {
            var db = new ClienteCrud();
            var item = new ClienteModel();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                db.InsertOrUpdate(item);
                gridDados.DataBind();
            }


        }

        protected void GridDados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}