using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;


namespace ComercioRudo
{
    public partial class ListaCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CategoriasNegocio negocio = new CategoriasNegocio();
            gdvListaCate.DataSource = negocio.listarConSP();
            gdvListaCate.DataBind();    


        }

        protected void btnAgregarCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCategoria.aspx", false);
        }
    }
}